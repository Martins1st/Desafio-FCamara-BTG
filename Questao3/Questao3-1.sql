select c.nome, v.placa from Veiculo v
inner join Cliente c on v.Cliente_cpf = c.cpf
