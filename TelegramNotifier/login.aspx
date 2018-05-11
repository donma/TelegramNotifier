<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TelegramNotifier.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="googlebot" content="noindex, nofollow" />
    <meta name="robots" content="noindex, nofollow" />
    <title>Telegram Notifier</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />




    <!-- Bootstrap 3.3.5 -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/admin-lte/2.4.3/css/AdminLTE.css" />
    <!-- iCheck -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/iCheck/1.0.2/skins/line/blue.css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

    <!-- jQuery 2.1.4 -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
    <!-- Bootstrap 3.3.5 -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/iCheck/1.0.2/icheck.min.js"></script>
    <script>
        (function ($) {
            $.fn.roundImage = function () {
                return this.each(function () {
                    var image = $(this),
                        imageWidth = image.width(),
                        imageHeight = image.height(),
                        imgSrc = image.attr('src'),
                        radius = Math.min(imageWidth, imageHeight) / 2,
                        uniqId = function () {
                            return Math.round(new Date().getTime() + (Math.random() * 100));
                        },
                        svgClipPathId = uniqId();
                    image.replaceWith('<svg width="' + imageWidth + '" height="' + imageHeight + '"><clipPath id="' + svgClipPathId + '"><circle r="' + radius + '" cx="' + imageWidth / 2 + '" cy="' + imageHeight / 2 + '"/></clipPath><image clip-path="url(#' + svgClipPathId + ')" xlink:href="' + imgSrc + '" src="' + imgSrc + '" width="' + imageWidth + '" height="' + imageHeight + '"></image></svg>');
                });
            };
        }(jQuery));
    </script>

    <%--icon--%>

    <link rel="apple-touch-icon" sizes="57x57" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="60x60" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="72x72" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="76x76" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="114x114" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="120x120" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="144x144" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="152x152" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="apple-touch-icon" sizes="180x180" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="icon" type="image/png" sizes="192x192" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="icon" type="image/png" sizes="32x32" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="icon" type="image/png" sizes="96x96" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="icon" type="image/png" sizes="16x16" href="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <link rel="manifest" href="icon/manifest.json">
    <meta name="msapplication-TileColor" content="#2471BA">
    <meta name="msapplication-TileImage" content="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png">
    <meta name="theme-color" content="#2471BA">


</head>
<body style="background-color: #252525" class="hold-transition login-page">
    <form id="form1" runat="server">
        <div class="login-box" style="opacity: .9; margin-top: 4%">
            <div class="login-logo">

                <a><b style="color: #E3E3E2; font-family: 微軟正黑體">Telegram

                </b><span style="color: gray; font-size: 10px; font-family: 微軟正黑體">Notifier</span>

                </a>
            </div>
            <!-- /.login-logo -->
            <div class="login-box-body">
                <p class="login-box-msg"></p>
                <div>
                    <div class="text-center form-group">
                        <img class="img-round" id="img1" style="width: 200px; height: 200px" src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Antu_telegram.svg/1024px-Antu_telegram.svg.png" alt="" />

                    </div>
                    <div class="form-group has-feedback">
                        <asp:TextBox ID="txtId" class="form-control" placeholder="帳號" runat="server" />
                        <span class="glyphicon glyphicon-user form-control-feedback"></span>
                    </div>

                    <div class="form-group has-feedback">
                        <asp:TextBox TextMode="Password" ID="txtPass" class="form-control" placeholder="Password" runat="server" />
                        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                    </div>

                    <div class="row">
                        <div class="col-xs-8">
                        </div>
                        <!-- /.col -->
                        <div class="col-xs-4">
                            <asp:LinkButton runat="server" style="font-family:微軟正黑體" class="btn btn-success btn-block btn-flat" OnClick="Unnamed1_Click">登入</asp:LinkButton>
                        </div>
                        <!-- /.col -->
                    </div>
                </div>


            </div>
            <!-- /.login-box-body -->
        </div>
        <!-- /.login-box -->


        <script>
            $(function () {
                $('input').iCheck({
                    checkboxClass: 'icheckbox_square-blue',
                    radioClass: 'iradio_square-blue',
                    increaseArea: '20%' // optional
                });
            });

            $('.img-round').roundImage();

        </script>

        <link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
        <asp:Literal ID="ltlS" runat="server"></asp:Literal>
    </form>
</body>
</html>

