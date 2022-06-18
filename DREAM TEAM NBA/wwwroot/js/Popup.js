function GameFineshed() {

    document.getElementById("popupSubDiv").style.background = "#0d0d0d"; //Cor do popup
    document.getElementById("popupSubDiv").style.background = "#0d0d0d"; //Cor do popup

    var bombaFeliz = document.querySelector("#imgPopup")
    bombaFeliz.parentNode.removeChild(bombaFeliz);
    document.getElementById("popupTitle").innerHTML = "Você Perdeu"; //Título
    document.getElementById("popupText").appendChild(bombaChorando)
    document.getElementById("btn1").innerHTML = "Jogar novamente";//Botão1
    document.getElementById("btn2").innerHTML = "Sair";//Botão2
    document.getElementById("popupDiv").style.display = "block";//Mostrando o Popup
}
