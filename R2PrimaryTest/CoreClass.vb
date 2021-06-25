
Namespace CoreClass
    Public Class R2CoreInstanceCaptchaManager

        Dim bmpCaptcha As Bitmap
        Dim iBMPHeight As Integer = 50
        Dim iBMPWidth As Integer = 150
        Dim sLeftMargin As Single = 5
        Dim sTopMargin As Single = 10
        Dim g As Graphics
        Dim sWord As String
        Dim sLetter As String
        Dim sfLetter As SizeF
        Dim rfLetter As RectangleF
        Dim sX1 As Single = 0
        Dim sY1 As Single = 0
        Dim sX2 As Single = 0
        Dim sY2 As Single = 0
        Dim sTemp As Single
        Dim iAngle As Integer
        Dim sOffset As Single

        Public Function GenerateCaptcha(ByVal sWord As String) As Bitmap
            Dim ixr As Integer
            bmpCaptcha = New Bitmap(iBMPWidth, iBMPHeight,
                        Drawing.Imaging.PixelFormat.Format16bppRgb555)
            g = Graphics.FromImage(bmpCaptcha)
            Dim drawBackground As New SolidBrush(Color.LawnGreen)
            g.FillRectangle(drawBackground, New Rectangle(0, 0, iBMPWidth, iBMPHeight))

            ' Create font and brush.
            Dim drawFont As New System.Drawing.Font("Alborz Titr", 16, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
            Dim drawBrush As New SolidBrush(Color.Red)
            Dim strFormat As New StringFormat(StringFormatFlags.FitBlackBox)
            sfLetter = New SizeF(30, 30)
            ' Draw string to screen.
            For ixr = 0 To sWord.Length - 1
                sLetter = sWord.Substring(ixr, 1)
                g = Graphics.FromImage(bmpCaptcha)
                rfLetter = New RectangleF(sLeftMargin, sTopMargin, 30, 30)
                sfLetter = g.MeasureString(sLetter, drawFont, sfLetter, strFormat)
                iAngle = RndInterval(0, 20) - 10
                With rfLetter
                    sOffset = sLeftMargin * Math.Tan(iAngle * Math.PI / 180)
                    .Y = sTopMargin - sOffset
                    .Width = sfLetter.Width + 10
                    .Height = sfLetter.Height
                End With
                g.RotateTransform(iAngle)
                g.DrawString(sLetter, drawFont, drawBrush, rfLetter)
                sLeftMargin += sfLetter.Width + 2
            Next
            Dim drawPen As Pen = New Pen(Color.Crimson, 1)
            For ixr = 0 To 3
                sX1 = sX2
                Do While Math.Abs(sX1 - sX2) < iBMPWidth * 0.5
                    sX1 = RndInterval(2, iBMPWidth - 2)
                    sX2 = RndInterval(2, iBMPWidth - 2)
                Loop
                sY1 = sY2
                Do While Math.Abs(sY1 - sY2) < iBMPHeight * 0.5
                    sY1 = RndInterval(2, iBMPHeight - 2)
                    sY2 = RndInterval(2, iBMPHeight - 2)
                Loop
                If RndInterval(0, 2) > 1 Then
                    sTemp = sX1
                    sX1 = sX2
                    sX2 = sTemp
                End If
                If RndInterval(0, 2) > 1 Then
                    sTemp = sY1
                    sY1 = sY2
                    sY2 = sTemp
                End If

                g.DrawLine(drawPen, sX1, sY1, sX2, sY2)
            Next
            g.Dispose()
            Return bmpCaptcha
        End Function
        Public Function GenerateFakeWord(ByVal iLengthRequired As Integer) As String
            Dim sVowels As String = "AEIOU"
            Dim sConsonants As String = "BCDFGHJKLMNPQRSTVWXYZ"
            Dim iNbrVowels As Integer
            Dim iNbrConsonants As Integer
            Dim sWord As String
            Dim bUseVowel As Boolean
            Dim iWordLength As Integer
            Dim sPattern As String
            iNbrVowels = 0
            iNbrConsonants = 0
            bUseVowel = False
            sWord = ""
            Randomize(DateTime.UtcNow.Millisecond)
            For iWordLength = 1 To iLengthRequired
                If (iWordLength = 2) Or ((iLengthRequired > 1) And (iWordLength = iLengthRequired)) Then
                    bUseVowel = Not bUseVowel
                ElseIf (iNbrVowels < 2) And (iNbrConsonants < 2) Then
                    bUseVowel = ((Rnd(1) * 2) > 1)
                ElseIf (iNbrVowels < 2) Then
                    bUseVowel = True
                ElseIf (iNbrConsonants < 2) Then
                    bUseVowel = False
                End If

                sPattern = IIf(bUseVowel, sVowels, sConsonants)
                sWord = sWord & sPattern.Substring(Int(Rnd(1) * sPattern.Length), 1)
                If bUseVowel Then
                    iNbrVowels = iNbrVowels + 1
                    iNbrConsonants = 0
                Else
                    iNbrVowels = 0
                    iNbrConsonants = iNbrConsonants + 1
                End If
            Next
            Return sWord
        End Function
        Public Function GenerateFakeWordNumeric(ByVal iLengthRequired As Integer) As String
            Dim sVowels As String = "98765"
            Dim sConsonants As String = "0123456789"
            Dim iNbrVowels As Integer
            Dim iNbrConsonants As Integer
            Dim sWord As String
            Dim bUseVowel As Boolean
            Dim iWordLength As Integer
            Dim sPattern As String
            iNbrVowels = 0
            iNbrConsonants = 0
            bUseVowel = False
            sWord = ""
            Randomize(DateTime.UtcNow.Millisecond)
            For iWordLength = 1 To iLengthRequired
                If (iWordLength = 2) Or ((iLengthRequired > 1) And (iWordLength = iLengthRequired)) Then
                    bUseVowel = Not bUseVowel
                ElseIf (iNbrVowels < 2) And (iNbrConsonants < 2) Then
                    bUseVowel = ((Rnd(1) * 2) > 1)
                ElseIf (iNbrVowels < 2) Then
                    bUseVowel = True
                ElseIf (iNbrConsonants < 2) Then
                    bUseVowel = False
                End If

                sPattern = IIf(bUseVowel, sVowels, sConsonants)
                sWord = sWord & sPattern.Substring(Int(Rnd(1) * sPattern.Length), 1)
                If bUseVowel Then
                    iNbrVowels = iNbrVowels + 1
                    iNbrConsonants = 0
                Else
                    iNbrVowels = 0
                    iNbrConsonants = iNbrConsonants + 1
                End If
            Next
            Return sWord
        End Function

        Private Function RndInterval(ByVal iMin As Integer, ByVal iMax As Integer) As Integer
            Randomize()
            Return Int(((iMax - iMin + 1) * Rnd()) + iMin)
        End Function


    End Class

End Namespace



