
//EVENTOS DA AGENDA
$("#OpenAgenda").on('click', function(){
    $("#modalAgenda").fadeIn();
    $("#caixaAgenda").slideDown();
});

$(".fechar").on('click', function(){
    $("#caixaAgenda").slideUp();
    $("#modalAgenda").fadeOut();
});
//DICA DE SAÚDE
$("#OpenDicasSaude").on('click', function(){
    $("#modalSaude").fadeIn();
    $("#caixaSaude").slideDown();
});

$(".fechar").on('click', function(){
    $("#caixaSaude").slideUp();
    $("#modalSaude").fadeOut();
});
//APOIADORES
$("#OpenApoiadores").on('click', function(){
    $("#modalApoiadores").fadeIn();
    $("#caixaApoio").slideDown();
});

$(".fechar").on('click', function(){
    $("#caixaApoio").slideUp();
    $("#modalApoiadores").fadeOut();
});
















