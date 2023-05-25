-- c) Liste as unidades de medida e a quantidade de produtos que existem para cada uma.


SELECT UnidadeMedida, COUNT(*) AS Produtos
FROM produto
GROUP BY UnidadeMedida;