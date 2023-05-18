var metafinanceira = (function () {
    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            excluir: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var Cadastrar = function () {
        var model = $('#formCadastrarMeta').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('Meta financeira cadastrada com sucesso!')
            location.href = configs.urls.index;
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var Excluir = function (id) {
        var model = {id: id};
        $.post(configs.urls.excluir, model).done(() => {
            location.href = configs.urls.index;
            site.toast.success('Meta financeira excluida com sucesso!')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        Cadastrar: Cadastrar,
        Excluir: Excluir
    }
})();
