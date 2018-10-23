CREATE USER 'user1'@'%' IDENTIFIED BY 'password1';
go
CREATE USER 'user2'@'localhost' IDENTIFIED BY 'password2';
GO
CREATE USER 'user3'@'localhost' IDENTIFIED BY 'password3';
GRANT ALL PRIVILEGES ON * . * TO 'user3'@'localhost';
GO
FLUSH PRIVILEGES;
GO
DROP USER 'user2'@'localhost';
DROP USER 'user3'@'localhost';
GO
GRANT ALL PRIVILEGES ON * . * TO 'user1'@'localhost';
GO
CREATE DATABASE 'template'
GO
CREATE TABLE  newTable1 (column_name column_type);
GO
//4. Из шаблона на предыдущем шаге создать новую БД ----НЕ СДЕЛАНО
//Проверить, что новая таблица появилась в новой БД ---НЕ СДЕЛАНО

CREATE USER 'user3'@'localhost' IDENTIFIED BY 'password3';
GRANT ALL PRIVILEGES ON 'template' . * TO 'user3'@'localhost';
GO
6. Создать табличное пространство, если получится)
CREATE TABLESPACE tableSpace1
DATAFILE '/pasx02/oradata/pasx/test01.dbf'
SIZE 500M;
GO
USE tableSpace1;
GO
CREATE DATABASE	db_inTableSpace;
GO
CREATE USER 'user5'@'localhost' IDENTIFIED BY 'password5';
GO
GRANT ALL PRIVILEGES ON 'db_inTableSpace' . * TO 'user5'@'localhost';
// Сделать выгрузку БД. Загрузить эту выгрузку в новую БД(db_reload)------НЕ СДЕЛАНО
// Дать все права в новой БД всем пользователям. ------НЕ СДЕЛАНО
// Удалить права для одного из пользователей на новую БД (user4) ------НЕ СДЕЛАНО
// Дать права пользователю user3 на выборку (SELECT), но не давать на (CREATE TABLE). Проверить, что всё корректно работает.
GRANT SELECT ON db_reload . * FROM 'user3'@'localhost';
REVOKE CREATE ON db_reload .* FROM 'user3'@'localhost';
