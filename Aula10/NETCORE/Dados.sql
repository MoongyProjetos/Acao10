--Select * from aluno

--INSERT INTO Aluno (Nome, DataNascimento) values ('Alice', '2017-03-02')

--Insert into Morada (Dados, Identificacao, AlunoId) values ('Rua das Casas, 10', 'Casa da Familia Silva', 2)

/*
Select aluno.Nome, Morada.Dados
from aluno, Morada
where aluno.Id = Morada.AlunoId
*/

--Select aluno.Nome, Morada.Dados
--from Aluno
--left join Morada on aluno.Id = morada.AlunoId
--where aluno.DataNascimento < '2018-01-10'

--update Aluno Set nome = 'Ines' where nome = 'Alice' and id = 3

--delete from Aluno where id = 3