/*********************Procedure que busca una fila por el valor exacto de dos campos (LOGGING)***************************/

DELIMITER $$
CREATE PROCEDURE `simplyselectwhere2fields`(in tabla varchar (40),in campo1 varchar (40),
in campo2 varchar (40),in datocampo1 varchar(100),in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` WHERE ",campo1," = '", datocampo1,"' and ",campo2," = '", datocampo2,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
