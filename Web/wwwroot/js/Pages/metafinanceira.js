var metafinanceira = (function () {
    var configs = {
        urls: {
            index: '',
            cadastrar: ''
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

    return {
        init: init,
        Cadastrar: Cadastrar
    }
})();
