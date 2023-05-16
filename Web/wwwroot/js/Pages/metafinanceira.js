var metafinanceira = (function () {
    var configs = {
        urls: {
            index: '',
            mostrarViewCadastrar: ''
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

    return {
        init: init,
        MostrarViewCadastrar: MostrarViewCadastrar
    }
})();
