#language: pt
@headless
Funcionalidade: Comentar
	Para aumentar a conversa com o blogueiro
	Enquanto leitor do blog
	Eu gostaria de comentar no blog

	Cenário: Comentando um post sem comentários
	Dado que eu tenho um post
	Quando eu vou na home do blog headless
	E comento o post
	Então o post fica comentado