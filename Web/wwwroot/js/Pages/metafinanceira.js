var metafinanceira = (function () {
    var configs = {
        urls: {
            index: '',
            mostrarViewCadastrar: '', 
            cadastrar: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var MostrarViewCadastrar = function () {
        $.get(configs.urls.mostrarViewCadastrar).done((html) => {
            $('#mostrarViewCadastrar').show();
            $('#mostrarViewCadastrar').html(html);
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var Cadastrar = function () {
        var model = $('#formCadastrarMeta').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('aluno cadastrado com sucesso')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        MostrarViewCadastrar: MostrarViewCadastrar,
        Cadastrar: Cadastrar
    }
})();
