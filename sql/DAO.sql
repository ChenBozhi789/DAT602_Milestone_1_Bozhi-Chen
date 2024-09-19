USE sys;
DROP DATABASE IF EXISTS DAODb;
CREATE DATABASE DAODb;
USE DAODb;

DROP PROCEDURE IF EXISTS MakeTables;
DELIMITER //
CREATE PROCEDURE MakeTables()
BEGIN
    CREATE TABLE tb_User(
        `UserID` INT(10) PRIMARY KEY AUTO_INCREMENT,
        `Username` VARCHAR(255),
        `Email` VARCHAR(255),
        `Password` VARCHAR(255)
    );
END //
DELIMITER ;

CALL MakeTables();