/*********************Procedure obtiene todos los campos de una columan y borra duplicados (SELECT DISTINCT)***************************/
DELIMITER $$
CREATE PROCEDURE `select_distinct`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT DISTINCT ",campo," FROM npms.",tabla,";");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;