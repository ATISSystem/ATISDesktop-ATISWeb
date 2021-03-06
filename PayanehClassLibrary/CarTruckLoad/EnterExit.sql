-- Script generated on 6/14/2012 9:09 AM
-- By: sa
-- Server: (LOCAL)

BEGIN TRANSACTION            
  DECLARE @JobID BINARY(16)  
  DECLARE @ReturnCode INT    
  SELECT @ReturnCode = 0     
IF (SELECT COUNT(*) FROM msdb.dbo.syscategories WHERE name = N'Database Maintenance') < 1 
  EXECUTE msdb.dbo.sp_add_category @name = N'Database Maintenance'

  -- Delete the job with the same name (if it exists)
  SELECT @JobID = job_id     
  FROM   msdb.dbo.sysjobs    
  WHERE (name = N'EnterExit')       
  IF (@JobID IS NOT NULL)    
  BEGIN  
  -- Check if the job is a multi-server job  
  IF (EXISTS (SELECT  * 
              FROM    msdb.dbo.sysjobservers 
              WHERE   (job_id = @JobID) AND (server_id <> 0))) 
  BEGIN 
    -- There is, so abort the script 
    RAISERROR (N'Unable to import job ''EnterExit'' since there is already a multi-server job with this name.', 16, 1) 
    GOTO QuitWithRollback  
  END 
  ELSE 
    -- Delete the [local] job 
    EXECUTE msdb.dbo.sp_delete_job @job_name = N'EnterExit' 
    SELECT @JobID = NULL
  END 

BEGIN 

  -- Add the job
  EXECUTE @ReturnCode = msdb.dbo.sp_add_job @job_id = @JobID OUTPUT , @job_name = N'EnterExit', @owner_login_name = N'sa', @description = N'No description available.', @category_name = N'Database Maintenance', @enabled = 1, @notify_level_email = 0, @notify_level_page = 0, @notify_level_netsend = 0, @notify_level_eventlog = 2, @delete_level= 0
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

  -- Add the job steps
  EXECUTE @ReturnCode = msdb.dbo.sp_add_jobstep @job_id = @JobID, @step_id = 1, @step_name = N'jobEnterExit', @command = N'
Declare @Tb Table(nEnterExitId numeric(20,2),strCardNo varchar(10),nIDGhabz int)
Declare @Tbtmp Table(nEnterExitId numeric(20,2),strCardNo varchar(10),nIDGhabz int)

insert into @Tbtmp
select distinct nEnterExitId,strCardNo,nIDGhabz from dbo.tbEnterExit E INNER JOIN
                      dbo.tbGhabz G ON G.nIDCar = E.strCardno --order by nIDGhabz
	where datediff(day,DBTransport.dbo.Udf_Shamsi2Milady(strEnterDate),getdate()) > 13  and bFlagDriver = 0	--and G.nIDCar = 5827 order by nIDGhabz
	order by nIDGhabz

insert into @Tb
select min(nEnterExitId) as nEnterExitId,strCardNo,min(nIDGhabz) as nIDGhabz from @tbTmp
	group by strCardNo

--select * from @Tb
--select * from @Tbtmp

declare @value numeric(10,2),@count int
DECLARE Employee_Cursor CURSOR FOR
SELECT * from @Tb
--SELECT * from @Tb
declare @nEnterExitId numeric(20,2),@strCardNo varchar(10),@nIDGhabz int,@newNobat int
declare @shdate datetime
declare @newDate as varchar(10)
--set @shDate = ''1387/11/19''
set @shdate = getDate()

OPEN Employee_Cursor
FETCH NEXT FROM Employee_Cursor into @nEnterExitId,@strCardNo,@nIDGhabz
WHILE @@FETCH_STATUS = 0
BEGIN
--print ''-------------------------''
--print @nEnterExitId
--print @strCardNo
--print @nIDGhabz
	set @value = 0.01
	set @newNobat = dbo.fnGetAnotherNobat(@nIDGhabz,@strCardNo,@shdate)
	set @newDate = ''1300/01/01''
	if @newNobat > 0 
		set @newDate = dbo.fnGetLastEnterDate(@strCardNo,@shdate)
	set @newDate = isnull(@newDate,''1300/01/01'')
	set @newNobat = isnull(@newNobat,0)
	--print @newNobat
	--print @newDate
	if @newNobat = 0
		--print ''-----------''
		update dbo.tbEnterExit set bFlagDriver = 1 where nEnterExitId = @nEnterExitId and strCardNo = @strCardNo
	else
	begin
	pp:
	set @newNobat = @newNobat + @value
	select @count = count(*) from dbo.tbEnterExit where nEnterExitId = @newNobat --and strCardNo = @strCardNo

	if isnull(@count,0) > 0 
	begin
		set @value = @value + 0.01
		goto pp
	end
--	print @newNobat
	update dbo.tbEnterExit set nEnterExitId = @newNobat,strEnterDate = @newDate where nEnterExitId = @nEnterExitId
		and strCardNo = @strCardNo

	end
FETCH NEXT FROM Employee_Cursor into @nEnterExitId,@strCardNo,@nIDGhabz
END
/*
select strCardNo,dbo.fnGetAnotherNobat(max(nIDGhabz))+0.1 FROM
         dbo.tbEnterExit E INNER JOIN
                      dbo.tbGhabz G ON G.nIDCar = E.strCardno --order by nIDGhabz
	where datediff(day,DBTransport.dbo.Udf_Shamsi2Milady(strEnterDate),getdate()) > 10 -- and bFlagDriver = 0
	group by strCardno

--select * from tbEnterExit
*/


', @database_name = N'dbtransport', @server = N'', @database_user_name = N'', @subsystem = N'TSQL', @cmdexec_success_code = 0, @flags = 0, @retry_attempts = 0, @retry_interval = 1, @output_file_name = N'', @on_success_step_id = 0, @on_success_action = 1, @on_fail_step_id = 0, @on_fail_action = 2
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 
  EXECUTE @ReturnCode = msdb.dbo.sp_update_job @job_id = @JobID, @start_step_id = 1 

  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

  -- Add the job schedules
  EXECUTE @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id = @JobID, @name = N'schEnterExit', @enabled = 1, @freq_type = 4, @active_start_date = 20091222, @active_start_time = 3000, @freq_interval = 1, @freq_subday_type = 8, @freq_subday_interval = 4, @freq_relative_interval = 0, @freq_recurrence_factor = 0, @active_end_date = 99991231, @active_end_time = 235959
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

  -- Add the Target Servers
  EXECUTE @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @JobID, @server_name = N'(local)' 
  IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback 

END
COMMIT TRANSACTION          
GOTO   EndSave              
QuitWithRollback:
  IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION 
EndSave: 


