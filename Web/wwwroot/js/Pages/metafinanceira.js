var metafinanceira = (function () {
    var configs = {
        urls: {
            index: '',
            cadastrar: ''
            // buscar: ''
        }
    }

    var init = function ($configs) {
        configs = $configs;
    };

    var Cadastrar = function () {
        var model = $('#formCadastrarMeta').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('Meta financeira cadastrada com sucesso!')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

//     var Buscar = function () {
//         $.get(configs.urls.buscar).done(function (html) {
// /*          $(".container-cadastrar").hide();
//             $(".container-lista").html(html);
//             $(".container-lista").show(); */
//         }).fail(function () {
//         })
//     };

    return {
        init: init,
        Cadastrar: Cadastrar
        // Buscar: Buscar
    }
})();
