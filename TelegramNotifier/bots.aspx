<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="bots.aspx.cs" Inherits="TelegramNotifier.bots" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderMain" runat="server">


    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">

        <section class="content" style="font-family: 微軟正黑體">

            <div class="box box-danger" style="font-family: 微軟正黑體">
                <div class="box-header">
                    <h2 class="page-header" style="font-family: 微軟正黑體">BOT List<span style="font-size: 14px; color: gray" id="log1"></span></h2>
                </div>

                <div class="row">

                    <div class="box-body">
                        <div class="panel-body">

                            <%--<hr/>--%>
                            <div class="table-responsive">
                                <asp:LinkButton runat="server" class="btn bg-aqua pull-right" ID="btnAdd" href="bot.aspx"><i class="fa fa-plus" aria-hidden="true"></i>&nbsp;Add Bots</asp:LinkButton>

                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>Token</th>
                                            <th>Users</th>
                                            <th>Messages</th>
                                            <th>LastUpdate</th>
                                            <th>Func</th>
                                        </tr>
                                    </thead>
                                    <tbody id="tb_main">

                                        <asp:Literal ID="ltlMain" runat="server"></asp:Literal>
                                    </tbody>

                                </table>


                            </div>
                            <!-- /.col -->
                        </div>
                    </div>
                </div>



            </div>

        </section>


    </div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceFooter" runat="server">
    <asp:Literal ID="ltlS" runat="server"></asp:Literal>
    <script>
        $('#li_bots').attr('class', 'active');
    </script>
</asp:Content>
