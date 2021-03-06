﻿function trimAll(sagestrJAVA) {
    if (sagestrJAVA != null) {
        while (sagestrJAVA.substring(0, 1) == ' ') {
            sagestrJAVA = sagestrJAVA.substring(1, sagestrJAVA.length);
        }
        while (sagestrJAVA.substring(sagestrJAVA.length - 1, sagestrJAVA.length) == ' ') {
            sagestrJAVA = sagestrJAVA.substring(0, sagestrJAVA.length - 1);
        }
    }
    return sagestrJAVA;
}
function NumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        if (charCode == 37 || charCode == 39)
            return true;
        if (charCode == 46)
            return true;
        if (charCode > 95 && charCode < 106)
            return true;
        return false;
    }
    return true;



}
function NumberKeyWithDecimal(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        if (charCode == 37 || charCode == 39)
            return true;
        if (charCode == 46)
            return true;
        if (charCode == 110)
            return true;
        if (charCode > 95 && charCode < 106)
            return true;
        return false;
    }
    return true;
}

function __sfe_SectionMaxMin(sender, obj, TemplateName) {

    var imgSrc = document.getElementById(sender);
    var el = document.getElementById(obj);
    if (el.style.display != "none") {
        el.style.display = 'none';
        imgSrc.src = imgSrc.src.replace("minus.png", "plus.png");
    }
    else {
        el.style.display = 'block';
        imgSrc.src = imgSrc.src.replace("plus.png", "minus.png");
    }
    __setCookie(obj, el.style.display, sender, TemplateName);
    return false;
}

function __sfe_SetMaxMin() {
    var x = document.cookie;
    if (x.length > 0) {
        var CollectedData = x.split(";");
        if (CollectedData.length > 0) {
            for (var i = 0; i < CollectedData.length; i++) {
                var ListColl = CollectedData[i];
                var arrColl = ListColl.split("=");
                if (arrColl.length > 0) {
                    var M_Temp = arrColl[0];
                    M_Temp = trimAll(M_Temp);
                    var el = document.getElementById(M_Temp);
                    var Temp = trimAll(arrColl[1]);
                    var arrRealColl = Temp.split("`");
                    if (arrRealColl.length > 1) {
                        var mimgTemp = trimAll(arrRealColl[1]);
                        var marrColl = mimgTemp.split("#");
                        if (marrColl.length > 1) {
                            mimgTemp = trimAll(marrColl[0]);
                            mTemplate = trimAll(marrColl[1]);
                            imgSrc = document.getElementById(mimgTemp);
                            if (el != null && imgSrc != null) {
                                if (trimAll(arrRealColl[0]) == "none") {
                                    el.style.display = 'none';
                                    imgSrc.src = imgSrc.src.replace("minus.png", "plus.png");
                                }
                                else {
                                    el.style.display = 'block';
                                    imgSrc.src = imgSrc.src.replace("plus.png", "minus.png");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

function __setCookie(c_name, value, sender, TemplateName) {
    var exdate = new Date();
    exdate.setDate(exdate.getDate());
    document.cookie = c_name + "=" + escape(value) + "`" + sender + "#" + TemplateName;
}
function __loadScript() {
    __clearsfecookie();
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(__sfe_SetMaxMin);
}
function __clearsfecookie() {
    var x = document.cookie;
    if (x.length > 0) {
        var CollectedData = x.split(";");
        if (CollectedData.length > 0) {
            for (var i = 0; i < CollectedData.length; i++) {
                var ListColl = trimAll(CollectedData[i]);
                var arrColl = ListColl.split("=");
                if (arrColl.length > 0) {
                    var M_Temp = trimAll(arrColl[0]);
                    var mydate = new Date();
                    mydate.setTime(mydate.getTime() - 1);
                    document.cookie = M_Temp + "=; expires=" + mydate.toGMTString();
                }
            }
        }
    }
}



function validateEmpty(id) {
    var fld = document.getElementById(id);
    if (fld.value.length == 0) {
        fld.style.background = 'Yellow';
        return false;
    } else {
        fld.style.background = 'White';
        return true;
    }

}


function hideModalPopup(modalPopupExtenderID) {
    var modalDialog = $find(modalPopupExtenderID);
    if (modalDialog != null) {
        modalDialog.hide();
    }
}

function showModalPopup(modalPopupExtenderID) {
    var modalDialog = $find(modalPopupExtenderID);
    if (modalDialog != null) {
        modalDialog.show();
    }
}

function jqCheckAll2(id, itemCssClass) {
    var $chkboxHeader = $("INPUT[id=" + id + "][type='checkbox']");
    if ($chkboxHeader) {
        var obj = $chkboxHeader.parent();
    }

    $('.' + itemCssClass + '[type="checkbox"]');
    $chkbox.siblings('ul').children().each(function() {
        var $sub = $(this).find('input[type=checkbox]').not(':disabled').attr('checked', $('#' + id).is(':checked'));

    });

}
function Check(chkbox, headerCheckboxClassName, gridViewID, chkClassName) {
    var isAllChecked = true;
    var gdv = document.getElementById(gridViewID);
    var headerCheckBox = null;
    var items = gdv.getElementsByTagName('input');
    for (i = 0; i < items.length; i++) {
        if (items[i].type == "checkbox") {
            if (items[i].className == chkClassName) {
                if (!(items[i].checked)) {
                    isAllChecked = false;
                    break;
                }
            }
            if (items[i].className == headerCheckboxClassName) {
                headerCheckBox = items[i];
            }
        }
    }
    if (headerCheckBox) {
        if (isAllChecked) {
            headerCheckBox.checked = true;
        }
        else {
            headerCheckBox.checked = false;
        }
    }
}

function HighlightRow(chkB) {
    var IsChecked = chkB.checked;
    if (IsChecked) {
        chkB.parentElement.parentElement.style.backgroundColor = '#228b22';
        chkB.parentElement.parentElement.style.color = 'white';
    } else {
        chkB.parentElement.parentElement.style.backgroundColor = 'white';
        chkB.parentElement.parentElement.style.color = 'black';
    }
}

function SelectAllCheckboxesSpecific(chkbox, gridViewID, chkClassName) {
    var IsChecked = chkbox.checked;
    var Chk = chkbox;
    gdv = document.getElementById(gridViewID);
    var items = gdv.getElementsByTagName('input');
    for (i = 0; i < items.length; i++) {
        if (items[i].type == "checkbox") {
            if (items[i].className == chkClassName) {
                if (items[i].checked != IsChecked) {
                    items[i].checked = IsChecked;
                }
            }
        }
    }
}
function changeCheckState(checked) {
    var frm = document.forms[0];
    for (i = 0; i < frm.length; i++) {
        if (frm.elements[i].id.indexOf('checkBox') != -1) {
            frm.elements[i].checked = checked;
        }
    }
}

function clickButton(e, buttonid) {
    var keyCode = window.event ? window.event.keyCode : e.which;
    var bt = document.getElementById(buttonid);
    if (bt) {
        if (keyCode == 13) {
            bt.click();
            return false;
        }
    }
}

var controlFaq;
function flipFlop(sender, eTarget, faqid, TemplateName, literal, usermoduleID, portalID) {
    var imgSrc = document.getElementById(sender);
    controlFaq = literal;
    if (document.getElementById(eTarget).style.display == 'none') {
        imgSrc.src = imgSrc.src.replace("imgExpand.png", "imgCollapse.png");
        document.getElementById(eTarget).style.display = 'block';
        SageFrame.SageFrameWebService.UpdateViewCount(faqid, usermoduleID, portalID, SucceededCallback);


    }
    else {
        imgSrc.src = imgSrc.src.replace("imgCollapse.png", "imgExpand.png");
        document.getElementById(eTarget).style.display = 'none';
    }
    return false;
}


function SucceededCallback(result, eventArgs) {

    $("#" + controlFaq).html(result);

}

function sageHtmlEncoder(EncoderControlID) {
    if (EncoderControlID != "") {
        var arrIds = EncoderControlID.split(",");
        for (var i = 0; i < arrIds.length; i++) {
            var obj = document.getElementById(arrIds[i]);
            var encodedString = __SageHTMLEncode(obj.value);
            obj.value = encodedString;
        }
        return false;
    }
}

function sageHtmlDecoder(DecoderControlID) {
    if (DecoderControlID != "") {
        var arrIds = DecoderControlID.split(",");
        for (var i = 0; i < arrIds.length; i++) {
            var obj = document.getElementById(arrIds[i]);
            var decodedString = __SageHTMLEncode(obj.value);
            obj.value = decodedString;
        }
        return false;
    }
}

function __SageHTMLEncode(text) {
    text = text.replace(
		/&/g, "&amp;").replace(
		/"/g, "&quot;").replace(
		/</g, "&lt;").replace(
		/>/g, "&gt;");
    return text;
}

function __SageHTMLDecode(text) {
    text = text.replace(/&gt;/g, '>');
    text = text.replace(/&lt;/g, '<');
    text = text.replace(/&amp;/g, '&');
    return text;
}

function InsertText(control, txtBox) {
    var con = document.getElementById(control);
    var txt = document.getElementById(txtBox);

    var mosPos = 0;

    if (document.selection) {
        txt.focus();
        var ran = document.selection.createRange();
        ran.text = con.value;
    }
    else if (txt.selectionStart != null) {
        mosPos = txt.selectionStart;
        var strFirst = txt.value.substring(0, mosPos);
        var strLast = txt.value.substring(mosPos);
        if (txt.value == "") {
            txt.value = con.value;
        }
        else {
            txt.value = strFirst + con.value + strLast;
        }
    }
    return false;
}

function ClickButtonOnInputBoxEnter(btnID) {
    var keycode;
    if (window.event) keycode = window.event.keyCode;
    else if (e) keycode = e.which;
    if (keycode == 13) {
        var btn = document.getElementById(btnID);
        if (btn) {
            btn.focus();
        }
    }
}

function stopRKey(evt) {
    var evt = (evt) ? evt : ((event) ? event : null);
    var node = (evt.target) ? evt.target : ((evt.srcElement) ? evt.srcElement : null);
    if ((evt.keyCode == 13) && (node.type == "text")) { return false; }
}

document.onkeypress = stopRKey;



function ValidateHTMLComments(txtCommentID, lblErrorID, ErrMessage) {
    if (document.getElementById(txtCommentID).value == "") {
        document.getElementById(lblErrorID).innerHTML = ErrMessage;
        return false;
    }
}


var TargetID = "";
var IsTextEditor = false;
var msgToken = "";
function showMessageToken(targetID, ModalPopupExtenderID, targetType) {

    TargetID = targetID;
    IsTextEditor = targetType;
    showModalPopup(ModalPopupExtenderID);
}

function AddMessageToken(msgTokenID, ModalPopupExtenderID) {

    if (IsTextEditor) {
        var fckEditorClientID = document.getElementById(TargetID);
        oEditor = FCKeditorAPI.GetInstance(fckEditorClientID.id);
        oEditor.InsertHtml(msgToken)
    }
    else {
        var hash = "#";
        var txtID = hash + TargetID;
        $(txtID).val($(txtID).val() + msgToken)
    }
    hideModalPopup(ModalPopupExtenderID);
}

function clearFCKEditor(FCKEditorID) {
    var fckEditorClientID = document.getElementById(FCKEditorID);
    oEditor = FCKeditorAPI.GetInstance(fckEditorClientID.id);
}
function setMessageToken(val) {
    msgToken = val;
}

function SetSearchValue(frmID, toID) {
    $("#" + toID).val($("#" + frmID).val());
}



////////////////////Added BY Niranjan ?//////////

function GetSystemLocale(text) {
    return SystemLocale[$.trim(text)] == undefined ? text : SystemLocale[$.trim(text)];
}

function getLocale(moduleKey, text) {
    return moduleKey[$.trim(text)] == undefined ? text : moduleKey[$.trim(text)];
}
$.fn.SystemLocalize = function() {
    return this.each(function() {

        var t = $(this);
        if (t.is("input:button")) {
            var text = t.attr("value");
            var localeValue = SystemLocale[$.trim(text)];
            t.attr("value", localeValue);
        }
        else {
            t.html(SystemLocale[$.trim(t.text())] == undefined ? $.trim(t.text()) : SystemLocale[$.trim(t.text())]);
        }
    }); return false;
};
$.fn.Localize = function(p) {
    return this.each(function() {
        var t = $(this);
        if (t.is("input:button")) {
            var text = t.attr("value");
            var localeValue = p.moduleKey[$.trim(text)] == undefined ? text : p.moduleKey[$.trim(text)];
            t.attr("value", localeValue);
        }
        else {
            t.html(p.moduleKey[$.trim(t.text())] == undefined ? $.trim(t.text()) : p.moduleKey[$.trim(t.text())]);
        }
    });
};
