<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ctl_MessageTemplateManagement.ascx.cs"
    Inherits="SageFrame.Modules.Admin.MessageManagement.ctl_MessageTemplateManagement" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<h1>
    <asp:Label ID="lblMessageTemplateManagement" runat="server" Text="Message Template Management"></asp:Label></h1>
<asp:Panel ID="pnlMessageTemplate" runat="server">
    <div class="sfFormwrapper">
        <h2 class="sfFormHeading">
            <asp:Label ID="lblAddEditMessageTemplate" runat="server" Text="Add/ Edit Message Template"></asp:Label></h2>
        <asp:HiddenField ID="hdnMessageTemplateID" runat="server" Value="0" />
        <table cellspacing="0" cellpadding="0" border="0" class="sfMessageTable">
            <tr>
                <td>
                    <asp:Label ID="lblMessageTemplateType1" runat="server" CssClass="sfFormLabel"
                        Text="Message Template Type"></asp:Label>
                </td>
                <td width="5%">
                    :
                </td>
                <td>
                    <asp:DropDownList ID="ddlMessageTemplateType" ToolTip="Select Message Template Type"
                        runat="server" OnSelectedIndexChanged="ddlMessageTemplateType_SelectedIndexChanged"
                        AutoPostBack="True" CssClass="sfListmenu">
                    </asp:DropDownList>
                    <asp:HyperLink ID="hypAddMessageTemplateType" runat="server" />
                    <asp:Label ID="lblAddMessageTemplateType" runat="server" Text="Add Message Template Type"
                        AssociatedControlID="hypAddMessageTemplateType"></asp:Label>
                    <asp:HyperLink ID="hypAddMessageTemplateToken" runat="server" />
                    <asp:Label ID="lblAddMessageTemplateToken" runat="server" Text="Add Message Template Token"
                        AssociatedControlID="hypAddMessageTemplateToken"></asp:Label>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFromEmail" runat="server" CssClass="sfFormLabel" Text="From Email"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtMailFrom" runat="server" ToolTip="From Email Address" ValidationGroup="vdgMessageTemplate"
                        CssClass="sfNormalTextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMailFrom"
                        ErrorMessage="*" ValidationGroup="vdgMessageTemplate" CssClass="sfError"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMailFrom"
                        SetFocusOnError="True" ErrorMessage="Invalid Email Address" ValidationGroup="vdgMessageTemplate"
                        Text="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        CssClass="sfError"></asp:RegularExpressionValidator>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSubject" runat="server" CssClass="sfFormLabel" Text="Subject"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <div style="float: left;">
                        <asp:TextBox ID="txtSubject" runat="server" ToolTip="Message template subject" ValidationGroup="vdgMessageTemplate"
                            CssClass="sfNormalTextBox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSubject"
                            SetFocusOnError="True" ErrorMessage="*" ValidationGroup="vdgMessageTemplate"
                            CssClass="sfsNormalRed"></asp:RequiredFieldValidator></div>
                    <div class="sfFormLinkButton">
                        <asp:HyperLink ID="lnkAddSubjectMessageToken" runat="server" Text="Add Subject Token" />
                        <asp:Label ID="lblAddSubjectMessageToken" runat="server" Text="Add Subject Token"
                            AssociatedControlID="lnkAddSubjectMessageToken" Style="cursor: pointer;" CssClass="sfFormLabel"></asp:Label></div>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMessage" runat="server" CssClass="sfFormLabel" Text="Message"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <div class="sfFormLinkButton">
                        <asp:HyperLink ID="lnkAddBodyMessageToken" runat="server" Text="Add Body Message Token" />
                        <asp:Label ID="lblAddBodyMessageToken" runat="server" Text="Add Body Message Token"
                            AssociatedControlID="lnkAddBodyMessageToken" Style="cursor: pointer;" CssClass="sfFormLabel"></asp:Label>
                    </div>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    <div class="sfCkeditor sfCurve">
                        <table cellspacing="0" cellpadding="0" border="0" id="tblTextEditor" runat="server"
                            width="100%">
                            <tbody>
                                <tr>
                                    <td id="Td1" class="editorheading" style="background-color: #ebcd5f;" runat="server">
                                        <asp:Label ID="lblEditorTitle" runat="server" CssClass="sfFormLabel" Text="Editor:" />
                                    </td>
                                </tr>
                                <tr>
                                    <td id="tdTextEditor" runat="server">
                                        <asp:Panel ID="pnlBasicTextBox" runat="server">
                                            <div id="divEdit" runat="server">
                                                <FCKeditorV2:FCKeditor ID="txtBody" runat="server" Height="450px" ToolbarSet="SageFrameLimited"
                                                    Width="100%">
                                                </FCKeditorV2:FCKeditor>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class="sfButtonwrapper">
                        <asp:Button ID="btnCustomizeEditor" runat="server" CausesValidation="False" CssClass="sfButtonEditor"
                            Text="Customize Editor" OnClick="btnCustomizeEditor_Click" />
                        <asp:Button ID="btnDefault" runat="server" CausesValidation="False" CssClass="sfButtonEditor"
                            Text="Default Editor" OnClick="btnDefault_Click" Visible="False" />
                    </div>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIsActive" runat="server" CssClass="sfFormLabel" Text="Is Active"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:CheckBox ID="chkIsActive" runat="server" CssClass="cssClassCheckBox" />
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    <div class="sfButtonwrapper">
        <asp:ImageButton ID="imbSave" runat="server" OnClick="imbSave_Click" ToolTip="Click to save"
            ValidationGroup="vdgMessageTemplate" />
        <asp:Label ID="lblSave" runat="server" Text="Save" AssociatedControlID="imbSave"
            Style="cursor: pointer;"></asp:Label>
        <asp:ImageButton ID="imbCancel" runat="server" OnClick="imbCancel_Click" ToolTip="Click to cancel"
            CausesValidation="False" />
        <asp:Label ID="lblCancel" runat="server" Text="Cancel" AssociatedControlID="imbCancel"
            Style="cursor: pointer;"></asp:Label>
    </div>
</asp:Panel>
<asp:Panel ID="pnlMessageTemplateList" runat="server">
    <div class="sfButtonwrapper">
        <asp:ImageButton ID="imbAddNew" runat="server" OnClick="imbAddNew_Click" ToolTip="Click to add message template" />
        <asp:Label ID="lblAddNew" runat="server" Text="Add New Message Template" AssociatedControlID="imbAddNew"
            Style="cursor: pointer;"></asp:Label>
    </div>
    <div class="sfGridwrapper">
        <asp:GridView ID="grdList" runat="server" AutoGenerateColumns="False" EmptyDataText="No Record to Show..."
            GridLines="None" AllowPaging="True" PageSize="15" BorderColor="White" BorderWidth="0px"
            OnPageIndexChanging="grdList_PageIndexChanging" OnRowCommand="grdList_RowCommand"
            OnRowDataBound="grdList_RowDataBound" OnRowDeleting="grdList_RowDeleting" OnRowEditing="grdList_RowEditing"
            OnRowUpdating="grdList_RowUpdating" Width="100%">
            <Columns>
                <asp:TemplateField HeaderText="Message Template Subject">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit" CommandArgument='<%# Eval("MessageTemplateID") %>'>
                            <asp:Label ID="lblSubject" runat="server" Text='<%# Eval("Subject") %>'></asp:Label>
                        </asp:LinkButton>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="From Email">
                    <ItemTemplate>
                        <asp:Label ID="lblFromEmail" runat="server" Text='<%# Eval("MailFrom") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" />
                </asp:TemplateField>
                <asp:BoundField DataField="IsActive" HeaderText="Is Active">
                    <HeaderStyle CssClass="cssClassColumnIsActive" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Added On">
                    <ItemTemplate>
                        <%# Eval("AddedOn","{0:yyyy/MM/dd}") %>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" CssClass="cssClassColumnAddedOn" />
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" Width="100px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Updated On">
                    <ItemTemplate>
                        <%# Eval("UpdatedOn","{0:yyyy/MM/dd}") %>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" CssClass="cssClassColumnUpdatedOn" />
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="imbEdit" runat="server" CausesValidation="False" CommandArgument='<%# Eval("MessageTemplateID") %>'
                            CommandName="Edit" ImageUrl='<%# GetTemplateImageUrl("imgedit.png", true) %>'
                            ToolTip="Edit" />
                    </ItemTemplate>
                    <HeaderStyle CssClass="cssClassColumnEdit" />
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top" />
                </asp:TemplateField>
            </Columns>
            <AlternatingRowStyle CssClass="cssClassAlternativeEven" />
            <HeaderStyle CssClass="cssClassHeadingOne" />
            <PagerStyle CssClass="sfPagination" />
            <RowStyle CssClass="cssClassAlternativeOdd" />
        </asp:GridView>
    </div>
</asp:Panel>
<cc2:ModalPopupExtender runat="server" ID="mpeAddMessageTokenModalPopup" TargetControlID="hiddenTargetControlForAddMessageTokenModalPopup"
    PopupControlID="pnlAddMessageTokenPopup" BackgroundCssClass="ModalPopupBG"
    OkControlID="btnAddMessageTokenOk" CancelControlID="btnAddMessageTokenCancel"
    PopupDragHandleControlID="pnlAddMessageTokenHandle" RepositionMode="RepositionOnWindowScroll"
    DynamicServicePath="" Enabled="True">
</cc2:ModalPopupExtender>
<asp:Panel ID="pnlAddMessageTokenPopup" runat="server" Style="display: none;">
    <div class="sfPopup">
        <div class="sfPopupinner">
            <asp:Panel ID="pnlAddMessageTokenHandle" runat="server" CssClass="cssClassPopTitle">
                Select message token</asp:Panel>
            <div class="sfPopupclose" id="btnAddMessageTokenCancel" runat="server">
            </div>
            <asp:Panel ID="pnlPopupBody" runat="server">
                <asp:ListBox ID="lstMessageToken" runat="server" Rows="10" CssClass="cssClassPopUpMessage">
                </asp:ListBox>
            </asp:Panel>
            <div class="sfButtonwrapper">
                <input type="button" id="btnAddMessageTokenOk" runat="server" value="Add" class="sfBtn" />
            </div>
        </div>
    </div>
</asp:Panel>
<asp:HiddenField runat="server" ID="hiddenTargetControlForAddMessageTokenModalPopup" />
<cc2:ModalPopupExtender BackgroundCssClass="ModalPopupBG" ID="mpeMessageTemplateType"
    OkControlID="btnCancelMessageTemplateType" CancelControlID="btnCancelMessageTemplateType"
    TargetControlID="btnopen" PopupControlID="pnlMessageTemplateType" PopupDragHandleControlID="pnlDragHandlerMessageTemplateType"
    RepositionMode="RepositionOnWindowScroll" runat="server" DynamicServicePath=""
    Enabled="True">
</cc2:ModalPopupExtender>
<asp:Panel ID="pnlMessageTemplateType" runat="server" Style="display: none"  CssClass="sfPopup">
    <asp:Panel ID="pnlDragHandlerMessageTemplateType" runat="server">
        <asp:Label ID="lblAMTT" runat="server" Text="Add Message Template Type" CssClass="cssClassPopTitle"></asp:Label>
    </asp:Panel>
    <div class="sfPopupclose" id="btnCancelMessageTemplateType" runat="server">
    </div>
    <div class="cssClassFormWrapper ">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblMessageTemplateType" runat="server" CssClass="cssClassFormLabel"
                        Text="Message Template Type"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtMessageTemplateType" runat="server" EnableViewState="False"></asp:TextBox>
                    <asp:Label ID="lblErrorMessageTemplateType" runat="server" CssClass="sfError"
                        Text="*" Visible="False"></asp:Label>
                    <asp:RequiredFieldValidator ID="rfvMessageTemplateType" runat="server" ControlToValidate="txtMessageTemplateType"
                        Display="Dynamic" ErrorMessage="Message Template Type Name Is Required" ValidationGroup="AddMsgTempType"
                        SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <div class="cssClassButtonWrapper">
            <asp:Button ID="btnOkMessageTemplateType" runat="server" Text="Add" OnClick="btnOkMessageTemplateType_Click" 
            ValidationGroup="AddMsgTempType" />
        </div>
    </div>
</asp:Panel>
<cc2:ModalPopupExtender BackgroundCssClass="ModalPopupBG" ID="mpeMessageTemplateToken"
    OkControlID="btnCancelMessageTemplateToken" CancelControlID="btnCancelMessageTemplateToken"
    TargetControlID="btnopen" PopupControlID="pnlMessageTemplateToken" PopupDragHandleControlID="pnlDragHandlerMessageTemplateToken"
    RepositionMode="RepositionOnWindowScroll" runat="server" DynamicServicePath=""
    Enabled="True">
</cc2:ModalPopupExtender>
<asp:Panel ID="pnlMessageTemplateToken" runat="server" Style="display: none" CssClass="sfPopup">
    <asp:Panel ID="pnlDragHandlerMessageTemplateToken" runat="server" CssClass="cssClassPopTitle">
        <asp:Label ID="lblMessageTempToken" runat="server" Text="Add Message Template Token"></asp:Label>
    </asp:Panel>
    <div class="sfPopupclose" id="btnCancelMessageTemplateToken" runat="server">
    </div>
    <div class="cssClassFormWrapper">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblMessageTemplateToken" runat="server" CssClass="cssClassFormLabel"
                        Text="Message Template Token"></asp:Label>
                </td>
                <td>
                    :
                </td>
                <td>
                    <asp:TextBox ID="txtMessageTemplateToken" runat="server" EnableViewState="False"></asp:TextBox>
                    <asp:Label ID="lblErrorMessageTemplateToken" runat="server" CssClass="cssClassError"
                        Text="*" Visible="False"></asp:Label>
                    <asp:RequiredFieldValidator ID="rfvMessageTemplateToken" runat="server" ControlToValidate="txtMessageTemplateToken"
                        Display="Dynamic" ErrorMessage="Message Template Token Name Is Required" ValidationGroup="AddMsgTempToken"
                        SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <div class="cssClassButtonWrapper">
            <asp:Button ID="btnOkMessageTemplateToken" runat="server" Text="Add" OnClick="btnOkMessageTemplateToken_Click"
                ValidationGroup="AddMsgTempToken" />
        </div>
    </div>
</asp:Panel>
<asp:HiddenField runat="server" ID="hdnAddMessageTemplateType" />
<asp:HiddenField runat="server" ID="hdnAddMessageTemplateToken" />
<asp:Button ID="btnopen" Style="display: none" runat="server" Text="Button" />

<script type="text/javascript">
    function ClearTemplateText(textControlID, errLblID) {
        var textBox = $("#" + textControlID);
        if (textBox != null) {
            $(textBox).val('');
        }
        var errLbl = $("#" + errLblID);
        if (errLbl != null) {
            $(errLbl).val('*');
            $(errLbl).hide();
        }
    }   
</script>

