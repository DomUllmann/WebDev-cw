<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="WebDev.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <h4>Change your account settings</h4>
                <hr />
                <dl class="dl-horizontal">
                    <dt>Username:</dt>
                    <dd><%: User.Identity.GetUserName() %></dd>
                    <dt>Password:</dt>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                    </dd>
                    <dt>Email:</dt>
                    <dd><%: GetEmail %></dd>
                    
                    <dt>Avatar:</dt>
                    <dd><img src="/Content/images/<%: AvatarUrl %>" alt="Avatar" width="64" height="64"/>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br/>
        <asp:Button ID="UploadButton" runat="server"
                    OnClick="UploadButton_Click"
                    Text="Upload File" />
                        <br />
                        
        <asp:Label ID="FileUploadedLabel" runat="server" />
                    </dd>
                </dl>
            </div>
        </div>
    </div>

</asp:Content>
