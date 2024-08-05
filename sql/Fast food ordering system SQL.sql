CREATE DATABASE LOGIN_DATA;
use LOGIN_DATA
CREATE TABLE signup
(
  firstname VARCHAR(50) NOT NULL,
  lastname VARCHAR(50) NOT NULL,
  email VARCHAR(50) Primary key,
  pass VARCHAR(50) NOT NULL,
  phonenum VARCHAR(50) NOT NULL,
  homeaddress VARCHAR(50) NOT NULL,
  cardnumber VARCHAR(16) NOT NULL, 
  expirydate varchar(20) NOT NULL,
  cvv INT NOT NULL,
  feedback Varchar(500) NULL
);
SELECT * FROM signup;

