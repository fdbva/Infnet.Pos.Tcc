(function ($, window) {
    //------------------Language-Grid-Mvc-Filter-----------------------------//

    MvcGrid.prototype.lang = {
        text: {
            'contains': "Contém",
            'equals': "Igual a",
            'not-equals': "Diferente de",
            'starts-with': "Começa com",
            'ends-with': "Termina com"
        },
        number: {
            'equals': "Igual a",
            'not-equals': "Diferente de",
            'less-than': "Menor que",
            'greater-than': "Maior que",
            'less-than-or-equal': "Menor ou igual que",
            'greater-than-or-equal': "Maior ou igual que"
        },
        enum: {
            'equals': "Igual a",
            'not-equals': "Diferente de"
        },
        date: {
            'equals': "Igual a",
            'not-equals': "Diferente de",
            'earlier-than': "Antes de",
            'later-than': "Depois de",
            'earlier-than-or-equal': "Antes ou no dia",
            'later-than-or-equal': "Depois ou no dia"
        },
        boolean: {
            'yes': "Sim",
            'no': "Não"
        },
        filter: {
            'apply': "✔",
            'remove': "✘"
        },
        operator: {
            'select': "",
            'and': "e",
            'or': "ou"
        }
    };
    [].forEach.call(document.getElementsByClassName("mvc-grid"), function (element) {
        new MvcGrid(element);
    });
})(jQuery, window);