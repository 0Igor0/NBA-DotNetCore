var x = 0
var ys = 0
var playersUsed = []
var positionsUsed = []
var permissionPlayer =true
var permissionPostion =true


function ChosePlayer(posicaoPassada) {//essa posição passada, também é um ID, que sera trocado pelo src do select
    permissionPlayer =true
    var select = $('#selected-box-players')[0];
    var value = select.options[select.selectedIndex].value; //os value da 5 checkBox contem os src dos jogadores
    CheckPlayers(value)
    var CampoJogador = $(`#${posicaoPassada}`)[0].src;

    if (CampoJogador == "https://localhost:7188/img/players/invisivel.png" && permissionPlayer == true) {

        
        $(`#${posicaoPassada}`)[0].src = `/img/players/${value}`;
        
    }
    
}

//updateTeam serve para mudar a logo e o nome dos jogadores do select
function UpdateTeam(logoTeam, namePlayer1, namePlayer2, namePlayer3, namePlayer4, namePlayer5, imgPlayer1, imgPlayer2, imgPlayer3, imgPlayer4, imgPlayer5, posicaoPassada) {
    permissionPostion = true
    var CampoJogador = $(`#${posicaoPassada}`)[0].src;
    CheckPositions(CampoJogador)
    if (permissionPostion == true) {

        $('#team-logo')[0].src = `/img/logo-team/${logoTeam}`;
        var select = $("#selected-box-players")[0]
        select.options[0].innerHTML = `PG - ${namePlayer1}`;
        select.options[1].innerHTML = `SG - ${namePlayer2}`;
        select.options[2].innerHTML = `PF - ${namePlayer3}`;        select.options[3].innerHTML = `SF - ${namePlayer4}`;
        select.options[4].innerHTML = `C - ${namePlayer5}`;
        select.options[0].value = `${imgPlayer1}`;
        select.options[1].value = `${imgPlayer2}`;
        select.options[2].value = `${imgPlayer3}`;
        select.options[3].value = `${imgPlayer4}`;
        select.options[4].value = `${imgPlayer5}`;
    }
    
}

function CheckPlayers(posicaoPassada) {


    for (var x = 0; x < 1000; x++) {
        if (posicaoPassada == playersUsed[x]) {
            permissionPlayer = false
        }
    }
    if (permissionPlayer == true) {
        playersUsed.push(posicaoPassada)
    }    

}

function CheckPositions(divPassada) {

    for (var x = 0; x < 4; x++) {
        if (divPassada == positionsUsed[x]) {
            permissionPostion = false
        }
    }
    if (permissionPostion == true) {
        positionsUsed.push(divPassada)
    }
}