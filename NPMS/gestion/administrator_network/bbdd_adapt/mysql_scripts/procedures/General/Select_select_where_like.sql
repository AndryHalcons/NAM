/*********************Procedure que busca una fila por el valor de una cadena (LIKE)***************************/
DELIMITER $$
CREATE PROCEDURE `simplyselectwherelike`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

