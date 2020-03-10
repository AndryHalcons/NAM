/*********************Procedure que comprueba si una tabla existe***************************/
DELIMITER $$
CREATE  PROCEDURE `table_exists`(
in tabla varchar (40))
BEGIN
SET @s = CONCAT("SHOW TABLES LIKE '",tabla,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
