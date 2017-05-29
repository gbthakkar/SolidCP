<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MailboxSelector.ascx.cs" Inherits="SolidCP.Portal.ExchangeServer.UserControls.MailboxSelector" %>

<asp:UpdatePanel ID="MainUpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
    <ContentTemplate>
            <div class="input-group">
<asp:TextBox ID="txtDisplayName" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                <span class="input-group-btn">
                                                <CPCC:StyleButton ID="ImageButton1" runat="server" CausesValidation="false" OnClick="ImageButton1_Click" meta:resourcekey="UserLookup" CssClass="btn btn-primary" />
                                                    
                                                <CPCC:StyleButton ID="cmdClear" runat="server" CssClass="btn btn-primary" meta:resourcekey="cmdClear" OnClick="cmdClear_Click" CausesValidation="False"/>
                                            </span>
                                        </div>
<asp:Panel ID="AddAccountsPanel" CssClas="container" runat="server" style="display:none">
	<div class="widget">
             <div class="widget-header clearfix">
                           <h3><i class="fa fa-user"></i> <asp:Localize ID="headerAddAccounts" runat="server" meta:resourcekey="headerAddAccounts"></asp:Localize></h3>
			 </div>
                    <div class="widget-content Popup">
<asp:UpdatePanel ID="AddAccountsUpdatePanel" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
    <ContentTemplate>
	            <div style="text-align:right;margin-bottom: 4px;">
					<asp:Localize ID="locIncludeSearch" runat="server" Text="Include in search:"></asp:Localize>
					<asp:CheckBox ID="chkIncludeMailboxes" runat="server" Text="Accounts" Checked="true"
							meta:resourcekey="chkIncludeMailboxes" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />
                    <asp:CheckBox ID="chkIncludeRooms" runat="server" Text="Rooms" Checked="true"
						    meta:resourcekey="chkIncludeRooms" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />
                    <asp:CheckBox ID="chkIncludeEquipment" runat="server" Text="Equipment" Checked="true"
							meta:resourcekey="chkIncludeEquipment" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />
                    <asp:CheckBox ID="chkIncludeSharedMailbox" runat="server" Text="Shared" Checked="true"
							meta:resourcekey="chkIncludeSharedMailbox" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />

					<asp:CheckBox ID="chkIncludeContacts" runat="server" Text="Contacts" Checked="true"
							meta:resourcekey="chkIncludeContacts" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />
					<asp:CheckBox ID="chkIncludeLists" runat="server" Text="Distribution Lists" Checked="true"
							meta:resourcekey="chkIncludeLists" AutoPostBack="true" CssClass="Normal" OnCheckedChanged="chkIncludeMailboxes_CheckedChanged" />
                </div>
                <div class="FormButtonsBarClean">
                    <div class="FormButtonsBarCleanRight">
                        <asp:Panel ID="SearchPanel" runat="server" DefaultButton="cmdSearch">
                            <asp:DropDownList ID="ddlSearchColumn" runat="server" CssClass="NormalTextBox">
                                <asp:ListItem Value="DisplayName" meta:resourcekey="ddlSearchColumnDisplayName">DisplayName</asp:ListItem>
                                <asp:ListItem Value="PrimaryEmailAddress" meta:resourcekey="ddlSearchColumnEmail">Email</asp:ListItem>
                            </asp:DropDownList><asp:TextBox ID="txtSearchValue" runat="server" CssClass="NormalTextBox" Width="100"></asp:TextBox><asp:ImageButton ID="cmdSearch" Runat="server" meta:resourcekey="cmdSearch" SkinID="SearchButton"
	                            CausesValidation="false" OnClick="cmdSearch_Click"/>
                        </asp:Panel>
                    </div>
                </div>
                <div class="Popup-Scroll">
					<asp:GridView ID="gvPopupAccounts" runat="server" meta:resourcekey="gvPopupAccounts" AutoGenerateColumns="False"
						Width="100%" CssSelectorClass="NormalGridView" AllowSorting="true"
						DataKeyNames="AccountName" OnRowCommand="gvPopupAccounts_RowCommand"  OnSorting="OnSorting">
						<Columns>
							<asp:TemplateField meta:resourcekey="gvAccountsDisplayName" SortExpression="DisplayName">
								<ItemStyle Width="50%"></ItemStyle>
								<ItemTemplate>
									<asp:Image ID="img1" runat="server" ImageUrl='<%# GetAccountImage((int)Eval("AccountType")) %>' ImageAlign="AbsMiddle" />
									<asp:LinkButton ID="cmdSelectAccount" CommandName="SelectAccount"
									CommandArgument='<%# Eval("AccountName").ToString() + "^" + Eval("DisplayName").ToString()+ "^" + Eval("PrimaryEmailAddress")+ "^" + Eval("AccountId")%>'
									runat="server" Text='<%# Eval("DisplayName") %>'></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField meta:resourcekey="gvAccountsEmail">
								<ItemStyle Width="50%"></ItemStyle>
								<ItemTemplate>
									<asp:Literal ID="litPrimaryEmailAddress" runat="server" Text='<%# Eval("PrimaryEmailAddress") %>'></asp:Literal>
								</ItemTemplate>
							</asp:TemplateField>
						</Columns>
					</asp:GridView>
				</div>
	</ContentTemplate>
</asp:UpdatePanel>
			<br /><br />
			<CPCC:StyleButton id="btnCancelAdd" CssClass="btn btn-warning" runat="server" CausesValidation="False"> <i class="fa fa-times">&nbsp;</i>&nbsp;<asp:Localize runat="server" meta:resourcekey="btnCancel"/> </CPCC:StyleButton>
		</div>
	</div>
</asp:Panel>

<asp:Button ID="btnSelectAccountFake" runat="server" style="display:none;" />
<ajaxToolkit:ModalPopupExtender ID="SelectAccountsModal" runat="server"
	TargetControlID="btnSelectAccountFake" PopupControlID="AddAccountsPanel"
	BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btnCancelAdd" />
	
	</ContentTemplate>
</asp:UpdatePanel>