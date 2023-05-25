-- d) Liste o nome e o estoque de todos os produtos, no dia 31/12/2022 (Dica: Use "LEFT JOIN").


SELECT p.Nome, SUM(COALESCE(t.Quantidade, 0)) AS Estoque
FROM Produto p
LEFT JOIN Transacao t ON p.IdProduto = t.IdProduto AND t.Data <= '2022-12-31'
GROUP BY p.Nome;