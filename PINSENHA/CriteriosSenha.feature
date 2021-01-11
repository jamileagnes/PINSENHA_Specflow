#language: pt

Funcionalidade: Criação dos critérios de senha
	Como: Gestor do Projeto Senha Internet
	Quero: Definir os critérios para geração de senha
	Para:  Usuários Internet que terão acesso aos serviços que requer autenticação no site SEFAZ-BA

	Cenario: Campo Senha dentro dos criterios definidos
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com dados validos
		Então o sistema permite a digitação da senha
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha Atual dentro dos critérios definidos
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com dados validos
		Então o sistema permite a digitação da senha
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Confirme a Senha dentro dos critérios definidos
		Quando acesso a tela para cadastro de senha
		E preencho o campo Confirme a Senha com dados validos
		Então o sistema permite a digitação da senha
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha dentro dos criterios definidos
		Quando acesso a tela para alteração da senha
		E preencho o campo Nova Senha com dados validos
		Então o sistema permite a digitação da senha
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha composta por caracteres especiais
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com caracteres especiais
		Então o sistema somente permite a digitação no campo senha de números ou letras
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha Atual composta por caracteres especiais
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com caracteres especiais
		Então o sistema somente permite a digitação no campo senha de números ou letras
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Confirme Senha composta por caracteres especiais
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha Atual com caracteres especiais
		Então o sistema somente permite a digitação no campo senha de números ou letras
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha composta por caracteres especiais
		Quando acesso a tela para alteração da senha
		E preencho o campo Nova Senha com caracteres especiais
		Então o sistema somente permite a digitação no campo senha de números ou letras
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha com menos de 7 caracteres
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com menos de 7 caracteres
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter exatamente 7 (sete) caracteres."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha Atual com menos de 7 caracteres
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com menos de 7 caracteres
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter exatamente 7 (sete) caracteres."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Confirme a Senha com menos de 7 caracteres
		Quando acesso a tela para cadastro de senha
		E preencho o campo Confirme a Senha com menos de 7 caracteres
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter exatamente 7 (sete) caracteres."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha com menos de 7 caracteres
		Quando acesso a tela para alteração da senha
		E preencho o campo Nova Senha com menos de 7 caracteres
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter exatamente 7 (sete) caracteres."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Confirme a Senha divergente do campo Senha
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com dados validos
		E preencho o campo Confirme a Senha com valor divergente do campo Senha
		Então o sistema exibe ao lado do campo mensagem informando que "As senhas não conferem!"
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha divergente do campo Confirme a Senha
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com dados validos
		E preencho o campo Confirme a Senha com dados validos
		E altero o campo Senha
		Então o sistema exibe ao lado do campo mensagem informando que "As senhas não conferem!"
		E mantem o botão Confirmar desabilitado
		
	Cenario: Campo Confirme a Senha divergente do campo Nova Senha
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com dados validos
		E preencho o campo Nova Senha com dados validos
		E altero o campo Confirme a Senha
		Então o sistema exibe ao lado do campo mensagem informando que "As senhas não conferem!"
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha divergente do campo Confime a Senha
		Quando acesso a tela para alteração da senha
		E preencho o campo Nova Senha com dados validos
		E preencho o campo Senha Atual com dados validos		
		E altero o campo Nova Senha
		Então o sistema exibe ao lado do campo mensagem informando que "As senhas não conferem!"
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha com valor igual ao do campo Senha Atual            
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com dados validos
		E preencho o campo Nova Senha com dados validos iguais aos do campo Senha Atual
		Então o sistema exibe ao lado do campo mensagem informando que "A nova senha deve ser diferente da senha anterior!"
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha com valores apagados  
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com dados validos
		E apago os valores digitados deixando o campo vazio 
		E clico fora do campo
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter letras e números."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Confirme a Senha com valores apagados
		Quando acesso a tela para cadastro de senha
		E preencho o campo Confirme a Senha com dados validos
		E apago os valores digitados deixando o campo vazio
		E clico fora do campo
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter letras e números."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Senha Atual com valores apagados
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com dados validos
		E apago os valores digitados deixando o campo vazio
		E clico fora do campo
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter letras e números."
		E mantem o botão Confirmar desabilitado

	Cenario: Campo Nova Senha com valores apagados
		Quando acesso a tela para alteração da senha
		E preencho o campo Nova Senha com dados validos
		E apago os valores digitados deixando o campo vazio
		E clico fora do campo
		Então o sistema exibe ao lado do campo mensagem informando que "A senha deve conter letras e números."
		E mantem o botão Confirmar desabilitado

	Cenario: Criação de senha
		Quando acesso a tela para cadastro de senha
		E preencho o campo Senha com dados validos
		E preencho o campo Confirme a Senha com dados validos e mesma informação preenchida no campo Senha
		E clico no botão Confirmar
		Então o sistema exibe mensagem de sucesso "Senha gerada com sucesso!" 
		E botão OK

	Cenario: Alteração de senha
		Quando acesso a tela para alteração da senha
		E preencho o campo Senha Atual com dados validos
		E preencho o campo Nova Senha com dados validos e informações diferentes da preenshida no campo Senha Atual
		E preencho o campo Confirme a Senha com dados validos e mesma informação preenchida no campo Nova Senha
		E clico no botão Confirmar
		Então o sistema exibe mensagem de sucesso "Senha gerada com sucesso!" 
		E botão OK