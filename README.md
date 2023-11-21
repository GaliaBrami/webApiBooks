# webApiBooks


## תיאור הפרויקט
מערכת לניהול השאלת ספרים באמצעות המערכת מנויים יכולים להשאיל ספרים וניתן לנהל את השאלות הספרים.
## ישויות

 - ספר
 - מנוי
 - השאלת ספר
 ## מיפוי Routes לספר
 - שליפת רשימת הספרים- GET https://api/Books
 - שליפת ספר לפי מזהה- GET https://api/Books/1
 - הוספת ספר- POST  https://api/Books 
 - עדכון ספר- PUT   https://api/Books/1
 - עדכון סטטוס- PUT   https://api/Books/1/status
  ## מיפוי Routes למנויים
 - שליפת רשימת המנויים- GET https://api/Members
 - שליפת מנוי לפי מזהה- GET https://api/Members/1
 - הוספת מנוי- POST  https://api/Members 
 - עדכון מנוי- PUT   https://api/Members/1
 -  עדכון סטטוס- PUT   https://api/Members/1/status
  ## מיפוי Routes להשאלות
 - שליפת רשימת ההשאלות- GET https://api/Borrow
 - שליפת השאלה לפי מזהה- GET https://api/Borrow/1
 - הוספת השאלה- POST  https://api/Borrow 
 - עדכון השאלה- PUT   https://api/Borrow/1
 - מחיקת השאלה- DELET  https://api/Borrow/1
