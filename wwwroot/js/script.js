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

let textoAtual = ""

botaoCopiar.addEventListener("click", function () {
    navigator.clipboard.writeText(textoAtual)
    botaoCopiar.textContent = "copiado!"
    setTimeout( function (){
        botaoCopiar.textContent = "copiar"
    }, 1500)
})

function renderizarTexto(texto) {
    textoResposta.innerHTML = ""

    const paragrafos = texto.split("\n\n")

    paragrafos.forEach(function (paragrafo) {
        const p = document.createElement("p")
        p.textContent = paragrafo
        textoResposta.appendChild(p)
    })
    const observer = new IntersectionObserver(function (entradas) {
        entradas.forEach(function (entrada) {
            entrada.target.classList.toggle("visivel", entrada.isIntersecting)
        })
    }, {
        root: textoResposta,
        threshold: 0.2
    })

    document.querySelectorAll("#textoResposta p").forEach(function (p) {
        observer.observe(p)
    })
}


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
        mensagemErro.textContent = dados.erro
        return
    
    }
    
    mensagemErro.textContent = ""
    textoAtual = dados.texto
    renderizarTexto(dados.texto)

    trocarTela(telaInicial, telaResposta)
}   