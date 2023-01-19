CREATE DATABASE temperature_converter_db
GO
USE temperature_converter_db
GO
CREATE TABLE temperature_convert_history (
	convert_id INT IDENTITY(1,1),
	converted_from VARCHAR(20) NOT NULL,
	converted_to VARCHAR(20) NOT NULL,
	converted_number INT NOT NULL,
	result VARCHAR(50) NOT NULL,
	converted_datetime DATETIME NOT NULL
)
