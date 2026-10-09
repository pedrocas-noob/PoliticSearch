const telaInicial = document.getElementById("telainicial")
const telaResposta = document.getElementById("telaResposta")
const inputNumero = document.getElementById("inputNumero")
const mensagemErro = document.getElementById("mensagemErro")
const textoResposta = document.getElementById("textoResposta")
const botaoCopiar = document.getElementById("botaocopiar")
const botaoSair = document.getElementById("botaosair")

inputNumero.addEventListener("keydown", function(evento){
    if (evento.key == "Enter"){
        buscarTopico()
    }
})

async function buscarTopico(){
    const numero = inputNumero.value

    const resposta = await fetch(`/api/topico/${numero}`)
    const dados = await resposta.json();

    if (!resposta.ok){
        mensagemErro,textContent = dados.erro
        return
    
    }
    
    mensagemErro.textContent = ""
    textoResposta.textContent = dados.texto

    telaInicial.classList.add("oculto")
    telaResposta.classList.remove("oculto")
}   