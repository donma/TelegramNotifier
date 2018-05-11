<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="messages.aspx.cs" Inherits="TelegramNotifier.messages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderMain" runat="server">


    <!-- Content Wrapper. Contains page content -->
    <div class="content-wrapper">

        <section class="content" style="font-family: 微軟正黑體">

            <div class="box box-success" style="font-family: 微軟正黑體">
                <div class="box-header">
                    <h2 class="page-header" style="font-family: 微軟正黑體">Message List<span style="font-size: 14px; color: gray" id="log1"></span></h2>
                </div>

                <div class="row">

                    <div class="box-body">
                        <div class="panel-body">

                            <%--<hr/>--%>
                            <div class="table-responsive">
                             
                                <table class="table">
                                    <thead>
                                        <tr>
                                             
                                            <th>Messages</th>
                                            <th>LastUpdate</th>
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