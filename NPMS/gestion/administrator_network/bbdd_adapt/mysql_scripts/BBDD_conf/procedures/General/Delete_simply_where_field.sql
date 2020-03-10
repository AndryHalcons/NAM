/*********************Procedure que borra una fila por el valor de un campo(DELETE)***************************/
DELIMITER $$
CREATE PROCEDURE `simply_delete_where`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(100))
BEGIN
SET @s = CONCAT("Delete FROM npms.`",tabla,"` where ",campo," = '", datocampo,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;


