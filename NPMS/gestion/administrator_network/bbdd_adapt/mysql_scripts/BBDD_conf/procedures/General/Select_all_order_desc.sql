/*********************Procedure que Hace un Select all con ORDER DESC (ideal para logs)***************************/
DELIMITER $$
CREATE PROCEDURE `simplyselectallorderdesc`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
