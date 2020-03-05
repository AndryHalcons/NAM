/*********************Procedure que Hace un Select all***************************/

DELIMITER $$
CREATE PROCEDURE `simplyselectall`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

