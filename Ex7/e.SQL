-- e) Liste o nome, o estoque mínimo e o estoque atual de todos os produtos, cujo estoque atual está abaixo do estoque mínimo (Dica: Use "HAVING").


SELECT p.Nome, p.EstoqueMinimo, SUM(COALESCE(t.Quantidade, 0)) AS EstoqueAtual
FROM Produto p
LEFT JOIN Transacao t ON p.IdProduto = t.IdProduto
GROUP BY p.Nome
HAVING SUM(COALESCE(t.Quantidade, 0)) < p.EstoqueMinimo;