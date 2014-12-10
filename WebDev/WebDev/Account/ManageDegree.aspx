<%@ Page Title="Manage Degree" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ManageDegree.aspx.cs" Inherits="WebDev.Account.ManageDegree" %>


                        
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
        <section id="degreeForm">
           ,<!-- <asp:PlaceHolder runat="server" ID="ChangeDegree" Visible="false">
                
                <div class="form-horizontal">
                    <h4>Change DegreeForm</h4>
                    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" CssClass="text-danger" />
                    <hr />
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="degree" CssClass="col-md-2 control-label">Degree</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="degree" TextMode="singleLine" CssClass="form-control" />
                            <!--<asp:RequiredFieldValidator runat="server" ControlToValidate="degree"
                                CssClass="text-danger" ErrorMessage="The password field is required."
                                Display="Dynamic" ValidationGroup="ChangeDegree" />
                            <asp:ModelErrorMessage runat="server" ModelStateKey="NewPassword" AssociatedControlID="password"
                                CssClass="text-danger" SetFocusOnError="true" />-->
                       <!-- </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="Change Degree" ValidationGroup="ChangeDegree" OnClick="ChangeDegree_Click" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
            </asp:PlaceHolder>-->

            
        </section>
    </div>
</asp:Content>
