<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"  CodeBehind="bot.aspx.cs" Inherits="TelegramNotifier.bot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <div class="content-wrapper">
        <section class="content" style="font-family: 微軟正黑體">

            <div class="box box-danger" style="font-family: 微軟正黑體">
                <div class="box-header">
                    <h2 class="page-header" style="font-family: 'Microsoft JhengHei'">BOT Infomation</h2>
                </div>
                <div class="row">

                    <div class="box-body">
                        <div class="panel-body">


                            <div class="col-lg-12 col-xs-12">

                                <div class="form-group">
                                    <label>System Key:</label>
                                    &nbsp;
                                        <span class="badge bg-red">
                                            <asp:Literal ID="ltlId" runat="server"></asp:Literal></span>
                                </div>

                                <div class="form-group">
                                    <label>BOT Title</label>

                                    <asp:TextBox placeholder="" ClientIDMode="Static" class="form-control" ID="txtTitle" runat="server"></asp:TextBox>

                                </div>

                                <div class="form-group">
                                    <label>Telegram BOT Token</label>

                                    <asp:TextBox placeholder="" ClientIDMode="Static" class="form-control" ID="txtTGToken" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <label>Broadcast Token</label>

                                    <asp:TextBox placeholder="" ClientIDMode="Static" class="form-control" ID="txtBCToken" runat="server"></asp:TextBox>

                                </div>

                            </div>



                            <div class="col-lg-12 col-xs-12">
                                <div class="form-group">
                                    <asp:LinkButton runat="server" ID="btnReceiveData" class="btn btn-success pull-right" ClientIDMode="Static" OnClick="btnReceiveData_Click"><i class="fa fa-floppy-o" aria-hidden="true"></i>&nbsp;Save BOT</asp:LinkButton>
                                </div>

                            </div>
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
