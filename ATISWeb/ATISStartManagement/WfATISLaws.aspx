<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfATISLaws.aspx.cs" Inherits="ATISWeb.ATISStartManagement.WfATISLaws" %>

<%@ Register TagPrefix="TWebControl" TagName="WcAlertShower" Src="~/AlertManagement/WcAlertShower.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>آتیس - قوانین و مقررات سایت</title>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <link href="~/Content/ATISFonts.css" rel="stylesheet" />
    <link href="~/Content/font-awesome.css" rel="stylesheet">

    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.5.1.min.js"></script>
    <script src="/Scripts/umd/popper.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <TWebControl:WcAlertShower runat="server" ID="WcAlertShower" />
        <div class="h-100">
            <br />
            <div class="container w-70">
                <div class="card m-auto">
                    <img class="card-img-top" src="/Images/Header4.jpg" alt="Card image cap" style="min-height: 10rem;" />
                    <div class="card-body">
                        <h6 class="card-title text-center R2FontBHomaLarge">سامانه آتیس</h6>
                        <h6 class="card-title R2FontBHomaLarge text-right">به سامانه اعلام بار مجازی آتیس خوش آمدید؛ تمامی افرادی که به صورت مستقیم یا غیر مستقیم از سامانه آتیس استفاده می‌کنند، باید شرایط زیر را به صورت کامل بپذیرند. محتوای این صفحه و شرایط و ضوابط استفاده از وب سایت ممکن است در هر زمانی بدون اطلاع به کاربران تغییر کند. تمامی تغییرات اعمال شده در این صفحه قابل مشاهده خواهند بود</h6>
                        <h6 class="card-title text-center R2FontBHomaLarge">دسترسی به وب سایت</h6>
                        <h4 class="card-title text-right R2FontBHomaLarge">خدمات و محتوای این وب سایت در دسترس عموم قرار ندارد ، امکان استفاده از امکانات سایت در حال حاضر فقط برای رانندگان حمل و نقل باری و شرکت ها و موسسات حمل و نقل امکان پذیر است.رانندگان برای عضویت در سایت می بایست ابتدا از طریق اپلیکیشن آتیس موبایل کلیه مدارک مورد نیاز را در سامانه بارگذاری نمایند.مدارک فوق بعد از بررسی توسط کارشناس مربوطه در سامانه رجیستر و اس ام اس با محتوای شناسه و رمز عبور برای راننده که هم اکنون به عنوان کاربر سامانه پذیرفته شده است ارسال می گردد.شرکت های حمل و نقل نیز می بایست ابتدا به صورت حضوری درخواست خود را به مدیریت سامانه تحویل نموده و منتظر تایید بمانند ، پس ازتایید ، اس ام اس شناسه و رمز عبور به شماره مدیر عامل شرکت ارسال خواهد شد</h4>
                        <h6 class="card-title text-center R2FontBHomaLarge"> مالکیت حقوقی</h6>
                        <h4 class="card-title text-right R2FontBHomaLarge">تمامی حقوق مادی و معنوی این وب سایت و محتوای آن از جمله حقوق کپی رایت نزد اداره کل راهداری و حمل و نقل جاده ای استان اصفهان محفوظ است. هیچ یک از محتوای ما کپی برداری از منابع داخلی و فارسی نبوده و اکثر محتوای موجود به صورت اختصاصی تولید شده اند. همچنین استفاده غیر شخصی از محتوای وب سایت نیز ممنوع است. در غیر این صورت ما این اجازه را به خود می‌دهیم تا از فرد و وب سایت کپی کننده شکایت کرده و یا وب سایت خاطی را از لیست نتایج موتورهای جستجوگر معروف از جمله گوگل و بینگ حذف نمائیم</h4>
                        <h6 class="card-title text-center text-right R2FontBHomaLarge">حریم شخصی افراد</h6>
                        <h4 class="card-title text-right R2FontBHomaLarge">هیچ یک از اطلاعات وارد شده حساس در این وب سایت (از جمله ایمیل‌ها، شماره تلفن و موبایل‌ها و سایر موارد) منتشر نخواهد شد و به صورت کامل نزد ما محفوظ خواهد ماند. برخی از اطلاعات پایه‌ای شما مانند آدرس IP توسط سرویس‌های آمارگیری (ازجمله Google Webmasters و Google Analytics) جمع آوری خواهند شد که فقط و فقط برای افزایش رضایت کاربران از این وب سایت استفاده قرار خواهند گرفت. اطلاعات غیرحساس مانند نام، نام خانوادگی ممکن است در قسمت‌های مختلف سایت به صورت عمومی نشان داده شوند.</h4>
                        <h6 class="card-title text-center R2FontBHomaLarge">شرایط و ضوابط استفاده از سامانه آتیس</h6>
                        <h4 class="card-title text-right R2FontBHomaLarge">:1- اعلام بار مجازی مطابق قوانین و آئین نامه های مصوب در اداره کل راهداری و حمل و نقل جاده ای استان اصفهان و با رعایت کامل تمام قوانین جمهوری اسلامی ایران صورت می پذیرد.2- محتوای سایت در اختیار عموم قرار ندارد. مالکیت معنوی اطلاعات موجود در سایت متعلق به اداره کل راهداری و حمل و نقل جاده ای استان اصفهان بوده و هر گونه سوء استفاده از این اطلاعات پیگرد قانونی دارد. استفاده تجاری از محتویات سایت ممنوع است3- شرکت های حمل و نقل هنگام اعلام بار می بایست اطلاعات صحیح و کامل را در پایگاه درج کنند. بدیهی است کاستی یا نادرستی اطلاعات، مانع تکمیل مراحل اعلام بار خواهد شد.4- مدیریت سایت هیچ گونه مسئولیتی را در مورد کارکرد ناقص سایت که می تواند ناشی از عوامل خارج از حوزه مدیریت این سایت باشد (همانند نقص اینترنت، مسائل مخابراتی، تجهیزات سخت افزاری و غیره) نمی پذیرد.5- ارتباط مدیریت سامانه با کاربران از طریق ATISSystem2023@Gmail.com   برقرار می گردد و فقط با استفاده از اطلاعاتی که کاربران در سایت درج کرده اند (همانند نشانی، تلفن و …) صورت می پذیرد.9- سامانه به هیچ وجه اطلاعات منحصر بفرد کاربران را به اشخاص و طرفین غیر، واگذار نخواهد کرد و ضمنا با استفاده از آخرین فن آوری ها متعهد است حتی المقدور از حریم شخصی کاربران دفاع کند. </h4>
                        <h6 class="card-title text-center R2FontBHomaLarge">شرایط و ضوابط خدمات</h6>
                        <h4 class="card-title text-right R2FontBHomaLarge">استفاده از سامانه آتیس به معنی توافق کامل شما با شرایط و ضوابط ذیل تلقی می گردد
با توجه به اختصاصی بودن سامانه در حوزه حمل ونقل باری ، خدمات فقط در اختیار رانندگان باری و شرکت ها و موسسات حمل و نقلی است.
 1- شرکت های حمل و نقل موظفند کلیه بارهای مصوب شده را ائم از آهن آلات و میلگرد و محصولات فولاد سبا در زمان های معین شده در سامانه ثبت نمایند.
2- رانندگان موظفند در زمان های معین شده و مصوب شده از طریق اپلیکیشن آتیس موبایل به انتخاب بار بپردازند.
 3- کلیه فرآیندها و عملیات کاربر در سامانه ثبت و قابل ردیابی است لذا در ثبت بار و انتخاب بار باید دقت کافی به عمل آید
4- رانندگان می توانند در صورت اعتراض به بار آزاد شده با شماره های پشتیبانی سامانه آتیس  03133863070 و یا 03133869114 تماس بگیرند.
5-کلیه هزینه ها ائم از هزینه نوبت و پارکینگ بر اساس مصوبات کارگروه سامانه آتیس برقرار می گردند.</h4>
                        <h4 class="card-title text-center R2FontBHomaLarge"></h4>
                    </div>
                    <h4 class="card-text text-center">ATIS</h4>
                    <br />
                </div>

            </div>
        </div>
        <script src="~/Scripts/popper.js"></script>
        <script src="~/Scripts/popper.min.js"></script>
        <script src="~/Scripts/bootstrap.min.js"></script>
        <script src="~/Scripts/bootstrap.js"></script>
        <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
        <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    </form>
</body>
</html>
