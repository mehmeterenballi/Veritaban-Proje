CREATE OR REPLACE TRIGGER UserDeleteTrigger AFTER DELETE ON "AspNetUsers" FOR EACH ROW
BEGIN
    DELETE FROM "Posts" WHERE "Sender" = :OLD."NickName";
END;
/

CREATE OR REPLACE PROCEDURE BannishUser(postID IN NUMBER, userNickName IN NVARCHAR2) IS
BEGIN
    INSERT INTO "BlackList" ("PostId", "Sender", "StartDate", "EndDate") VALUES(postID, userNickName, sysdate, sysdate + 7);
    DELETE FROM "Posts" WHERE "Id" = postID;
END;
/


/*SELECT * FROM "Posts";
SELECT * FROM "BlackList";

DELETE FROM "BlackList";
*/


EXEC BannishUser(2, 'WhiteHare');


CREATE VIEW Admins AS SELECT * FROM "AspNetUsers" WHERE "IsAdmin" = 1;
SELECT * FROM Admins;

CREATE VIEW BannedUsers AS SELECT * FROM "AspNetUsers" WHERE "NickName" IN (SELECT "NickName" FROM "BlackList"); 
SELECT * FROM BannedUsers;



COMMIT;