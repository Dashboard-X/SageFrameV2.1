/// <reference path="../../../Scripts/jquery-1.4.1.js" />

(function () {
    var o = { exec: function (p) {
        alert("called");
        url = "Act.aspx";
        $.post(url, function (response) {
            alert(response)
        });
    }
    };
    CKEDITOR.plugins.add('newplugin', {
        init: function (editor) {
            editor.addCommand('newplugin', o);
            editor.ui.addButton('newplugin', {
                label: 'newplugin',
                icon: this.path + 'newplugin.png',
                command: 'newplugin'
            });
        }
    });
})();