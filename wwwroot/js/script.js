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

botaoSair.addEventListener("click", function(){
    trocarTela(telaResposta, telaInicial)
    inputNumero.value = ""
})

function trocarTela(telaSair, telaEntrar) {
    gsap.to(telaSair, {
        opacity: 0,
        duration: 0.4,
        onComplete: function () {
            telaSair.classList.add("oculto")
            telaEntrar.classList.remove("oculto")
            gsap.fromTo(telaEntrar, { opacity: 0}, { opacity: 1, duration: 0.4})   
        }
    })
}

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

    trocarTela(telaInicial, telaResposta)
}   