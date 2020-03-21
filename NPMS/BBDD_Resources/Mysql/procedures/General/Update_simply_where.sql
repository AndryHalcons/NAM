/*********************Procedure que realiza un UPDATE de un campo, por where otro campo***************************/
DELIMITER $$
CREATE PROCEDURE `symply_where_update`(in tabla varchar (40),in campo1 varchar (40),in campo2 varchar(100),
in datocampo1 varchar (40), in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("UPDATE `npms`.`",tabla,"` SET ",campo1," = '", datocampo1,"' WHERE (`", campo2,"` = '",datocampo2,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
