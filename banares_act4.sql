/* EDP Activity 4: Login with UX
Develop the login system of your information system. 
Design the user interface (at least  5 )of your system simulating the business process / functions. 
Upload the solution files in zip format and PDF containing screen shots of your UX.*/

CREATE DATABASE rental_db;
USE rental_db;

-- Create Tables
CREATE TABLE users (
	user_id int auto_increment primary key,
    fname varchar(30) not null,
    lname varchar(30) not null,
    username varchar(50) not null,
    email varchar(50),
    user_password varchar(50) not null,
    user_role varchar(50)
);

CREATE TABLE categories (
	category_id int auto_increment primary key,
    category_name varchar(50) not null
);

CREATE TABLE items (
	item_id int auto_increment primary key,
    item_name varchar(50) not null,
    image varchar(50),
    item_desc text,
    category_id int,
    foreign key (category_id) references categories (category_id),
    price decimal(10,2) not null,
    owner_id int,
    foreign key (owner_id) references users (user_id),
    item_status varchar(30) not null
);

CREATE TABLE rentals (
	rental_id int auto_increment primary key,
    renter_id int,
    item_id int not null,
    owner_id int,
    rental_date date,
    return_date date,
    price_payable decimal(10,2),
    rental_status varchar(50),
    foreign key (item_id) references items (item_id),
    foreign key (owner_id) references users (user_id),
    foreign key (renter_id) references users (user_id)
);

CREATE TABLE rentals_archived (
	rental_id int auto_increment primary key,
    renter_id int not null,
    item_id int not null,
    owner_id int,
    rental_date date not null,
    return_date date,
    price_payable decimal(10,2),
    rental_status varchar(50),
    foreign key (item_id) references items (item_id),
    foreign key (owner_id) references users (user_id),
    foreign key (renter_id) references users (user_id)
);

CREATE TABLE payment (
	payment_id int auto_increment primary key,
    rental_id int not null,
    renter_id int not null,
    owner_id int not null,
    payment_date timestamp default current_timestamp,
    amount decimal(10,2) not null,
    foreign key (renter_id) references users (user_id),
    foreign key (owner_id) references users (user_id),
    foreign key (rental_id) references rentals (rental_id)
);

-- Add Records
INSERT INTO users (fname, lname, username, email, user_password, user_role)
VALUES 
	('admin', 'EasyRent', 'admin', 'admin@gmail.com', md5('admin'), 'admin'),
    ('Ed', 'Sheeran', 'sheeraned', 'eds@gmail.com', md5('coder102'), 'renter'),
    ('Sheena', 'Barnedo', 'sheenab', 'shebar@gmail.com', md5('she111'), 'renter'),
    ('Lea', 'Vuiton', 'vuitonl', 'lv@gmail.com', md5('bagIsLife12'), 'renter'),
    ('Anya', 'Forger', 'anyaforger', 'anya@gmail.com', md5('t5fess'), 'renter'),
    ('Brian', 'Lim', 'brylim', 'brianlim@gmail.com', md5('ynnfndsg'), 'renter'),
    ('Morty', 'Lee', 'mlee', 'morty@gmail.com', md5('ee4dga2'), 'renter'),
    ('Rick', 'Brown', 'rickb', 'rick@gmail.com', md5('ee23s'), 'renter'),
    ('Loid', 'Grim', 'loidgrim', 'loid@gmail.com', md5('lee256'), 'renter'),
    ('Mike', 'Sy', 'msy', 'mikesy@gmail.com', md5('pass182'), 'renter');
    
INSERT INTO categories (category_name)
VALUES 
	('Camera'),
    ('Music'),
    ('Clothing'),
    ('Tools'),
    ('Electronics'),
    ('Wedding'),
    ('Home'),
    ('Kitchen'),
    ('Games'),
    ('Sports');
    
INSERT INTO items (item_name, item_desc, image, category_id, price, owner_id, item_status)
VALUES 
	('Barong', 'For weddings and graduation', 'barong.jpg', 3, 200.50, 1, 'available'),
    ('Alampay', 'For graduation', 'alampay.jpg', 3, 150.20, 2, 'available'),
    ('Laptop', 'For students', 'laptop1.jpg', 5, 350.25, 1, 'available'),
    ('Hair Straightener', 'Good quality, brand new', 'hair.jpg', 7, 100.00, 4, 'available'),
    ('Xylophone', 'Used but good', 'xylo.jpg', 2, 100.10, 3, 'available'),
    ('Drum', '3 years but still sound good', 'drum.jpg', 2, 100.75, 2, 'available'),
    ('Keyboard', 'Good and functional keyboard for IT', 'keyboard.jpg', 5, 200.65, 8, 'available'),
    ('Guitar', 'Rock and roll', 'guitar1.jpg', 2, 300.00, 9, 'available'),
    ('Camera', 'Good for memoery keeping', 'camera.jpg', 5, 500.75, 5, 'available'),
    ('Roller Skates', 'Used but still good', 'roller.jpg', 10, 700.45, 6, 'available');
    
INSERT INTO rentals (renter_id, item_id, owner_id, rental_date, return_date, price_payable, rental_status)
VALUES 
	(1, 2, 3, '2023-01-01', '2023-03-02', 150.20, 'active'),
    (2, 1, 3, '2023-01-15', '2023-03-01', 200.50, 'completed'),
    (3, 5, 4, '2023-01-10', '2023-02-10', 100.10, 'active'),
    (4, 6, 5, '2023-01-05', '2023-02-06', 100.75, 'active'),
    (5, 7, 8, '2023-01-20', '2023-02-20', 200.65, 'active'),
    (6, 9, 1, '2023-01-08', '2023-02-08', 300.00, 'active'),
    (7, 10, 2, '2023-01-13', '2023-02-13', 700.45, 'active'),
    (8, 3, 7, '2023-01-02', '2023-02-02', 350.25, 'active'),
    (9, 4, 6, '2023-01-04', '2023-02-04', 100.00, 'active'),
    (10, 8, 9, '2023-01-14', '2023-02-14', 500.75, 'completed');

INSERT INTO payment (rental_id, renter_id, owner_id, amount)
VALUES 
	(10, 7, 2, 200.50),
    (9, 8, 1, 100.00),
    (8, 10, 9, 150.25),
    (7, 9, 10, 200.25),
    (6, 2, 3, 350.25),
    (5, 1, 5, 100.10),
    (4, 4, 6, 200.50),
    (3, 3, 7, 200.00),
    (2, 6, 4, 100.25),
    (1, 5, 8, 300.00);
    
-- Create Views
-- View all available items
CREATE VIEW available_items AS
SELECT i.item_id, i.item_name, c.category_name,  u.username AS owner_username, i.price
FROM items i
INNER JOIN categories c ON i.category_id = c.category_id
INNER JOIN users u ON i.owner_id = u.user_id
WHERE i.item_status = 'available';

-- View items rented by renters
CREATE VIEW rentals_by_renter AS
SELECT r.rental_id, u.username, i.item_name, c.category_name, r.rental_date, r.return_date, r.price_payable
FROM rentals r
INNER JOIN items i ON r.item_id = i.item_id
INNER JOIN categories c ON i.category_id = c.category_id
INNER JOIN users u ON r.renter_id = u.user_id;

-- View a summary of rental payments
CREATE VIEW payment_summary AS
SELECT p.payment_id, p.rental_id, CONCAT(ru.fname, ' ', ru.lname) AS renter_name, CONCAT(ou.fname, ' ', ou.lname) AS owner_name, p.payment_date, p.amount,
    CASE WHEN r.return_date <= CURRENT_DATE() THEN 'Completed' ELSE 'Pending' END AS status
FROM payment p
INNER JOIN rentals r ON p.rental_id = r.rental_id
INNER JOIN users ru ON r.renter_id = ru.user_id
INNER JOIN items i ON r.item_id = i.item_id
INNER JOIN users ou ON i.owner_id = ou.user_id;

-- Create Procedure
-- Procedure that updates the price of items for rent
DELIMITER //
CREATE PROCEDURE update_price (IN category_name varchar(50), IN new_price decimal(10,2))
BEGIN
    UPDATE items i
    JOIN categories c ON i.category_id = c.category_id
    SET i.price = new_price
    WHERE c.category_name = category_name;
    
    UPDATE rentals r
    JOIN items i ON r.item_id = i.item_id
    JOIN categories c ON i.category_id = c.category_id
    SET r.price_payable = new_price
    WHERE c.category_name = category_name;
END //
DELIMITER ;

-- Create Function
-- Function that calculates the total cost of all rentals made by a specific user
DELIMITER //
CREATE FUNCTION total_cost(input_renter_id INT)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE total_cost DECIMAL(10,2) DEFAULT 0;
    SELECT SUM(price_payable) INTO total_cost
    FROM rentals
    WHERE renter_id = input_renter_id;
    RETURN total_cost;
END//
DELIMITER ;

-- Create trigger during insert event
-- A trigger that automatically checks if an email is valid or not.
-- If it is not, it will show an error message.
DELIMITER //
CREATE TRIGGER validate_email
BEFORE INSERT ON users
FOR EACH ROW
BEGIN
    IF NOT NEW.email REGEXP '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$' THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid email format';
    END IF;
END //
DELIMITER ;

-- Create trigger during update event
-- A trigger that automatically updates the item status once it is rented out
DELIMITER //
CREATE TRIGGER update_item_status 
AFTER INSERT ON rentals
FOR EACH ROW
BEGIN
    UPDATE items SET item_status = 'unavailable' WHERE item_id = NEW.item_id;
END //
DELIMITER ;

-- Create trigger during update event
-- A trigger that automatically updates the payable_price on the rentals table
DELIMITER //
CREATE TRIGGER update_price_payable
BEFORE INSERT ON rentals
FOR EACH ROW
BEGIN
    DECLARE rental_days INT;
    DECLARE rental_price DECIMAL(10,2);
    
    SET rental_days = DATEDIFF(NEW.return_date, NEW.rental_date);
    SET rental_price = (SELECT price FROM items WHERE item_id = NEW.item_id);
    
    SET NEW.price_payable = rental_days * rental_price;
END //
DELIMITER ;

-- Create trigger during delete event
-- This trigger automatically checks if a rental record is active.
-- If it is, then it will show an error message that the record is not deletable.
DELIMITER //
CREATE TRIGGER rental_deletion
BEFORE DELETE ON rentals
FOR EACH ROW
BEGIN
    IF OLD.rental_status = 'active' THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Cannot delete an active rental';
    END IF;
END //
DELIMITER ;

-- Create trigger during delete event
-- This trigger automatically put a rental record to the rentals_archived
-- before it is deleted to the rentals table.
DELIMITER //
CREATE TRIGGER archive_rentals
BEFORE DELETE ON rentals
FOR EACH ROW
BEGIN
  IF OLD.rental_status = 'completed' OR OLD.rental_status = 'cancelled' THEN
    INSERT INTO rentals_archived
      (rental_id, renter_id, item_id, owner_id, rental_date, return_date, price_payable, rental_status)
    VALUES
      (OLD.rental_id, OLD.renter_id, OLD.item_id, OLD.owner_id, OLD.rental_date, OLD.return_date, OLD.price_payable, OLD.rental_status);
  END IF;
END //
DELIMITER ;