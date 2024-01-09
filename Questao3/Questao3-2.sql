select p.ender, e.dtEntrada, e.dtSaida from
Estaciona e
inner join Patio p on p.num = e.Patio_num
where e.Veiculo_placa = 'BTG-2022'