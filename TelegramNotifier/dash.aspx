<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="dash.aspx.cs" Inherits="TelegramNotifier.dash" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderMain" runat="server">


    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1 style="font-family: 微軟正黑體">
                <asp:Literal ID="ltlBTitle" runat="server"></asp:Literal>

                <small>
                    <asp:Literal ID="ltlBTitle2" runat="server"></asp:Literal>
                </small>
            </h1>

        </section>
        <section class="content" style="font-family: 微軟正黑體">


            <!-- Small boxes (Stat box) -->
            <div class="row">

                <div class="col-lg-3 col-xs-6">
                    <!-- small box -->
                    <div class="small-box bg-red">
                        <div class="inner">
                            <h3>
                                <asp:Literal ID="ltlBots" runat="server" Text="0"></asp:Literal></h3>
                            <p>&nbsp;BOTs</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-reddit-alien" aria-hidden="true"></i>
                        </div>
                        <a href="#" class="small-box-footer">&nbsp;</a>
                    </div>
                </div>
                <!-- ./col -->


                <div class="col-lg-3 col-xs-6">
                    <!-- small box -->
                    <div class="small-box bg-blue">
                        <div class="inner">
                            <h3>
                                <asp:Literal ID="ltlUser" runat="server" Text="0"></asp:Literal></h3>
                            <p>&nbsp;用戶</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-user" aria-hidden="true"></i>
                        </div>
                        <a href="#" class="small-box-footer">&nbsp;</a>
                    </div>
                </div>
                <!-- ./col -->

                <div class="col-lg-3 col-xs-6">
                    <!-- small box -->
                    <div class="small-box bg-aqua">
                        <div class="inner">
                            <h3>
                                <asp:Literal ID="ltlMessage" runat="server" Text="0"></asp:Literal></h3>
                            <p>&nbsp;Messages</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-comments-o" aria-hidden="true"></i>
                        </div>
                        <a href="#" class="small-box-footer">&nbsp;</a>
                    </div>
                </div>
                <!-- ./col -->

            </div>
            <!-- /.row -->



        </section>
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceFooter" runat="server">
    <asp:Literal ID="ltlS" runat="server"></asp:Literal>
    <script>

        $('#li_dash').attr('class', 'active');

    </script>

</asp:Content>

