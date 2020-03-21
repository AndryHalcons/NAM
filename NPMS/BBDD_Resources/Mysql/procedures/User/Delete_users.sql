DELIMITER $$
CREATE PROCEDURE `delete_user`(in Accion varchar (40),in Usuario varchar (40),in For_user varchar(100))
BEGIN

 SET @s = CONCAT("insert into `log_user`
(`User`,`Rol`)
select `User`, `Rol`
from `usuarios` where User ='", Usuario,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_user);
UPDATE `npms`.`log_user` SET `Action` = Accion, `For_User` = For_user WHERE `ID` = @max_id;   
SET @b = CONCAT("DELETE FROM `npms`.`usuarios` WHERE (`User` = '", Usuario,"');");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
