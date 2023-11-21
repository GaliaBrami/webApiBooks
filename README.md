# webApiBooks-Library


## תיאור הפרויקט
מערכת לניהול השאלת ספרים באמצעות המערכת מנויים יכולים להשאיל ספרים וניתן לנהל את השאלות הספרים.
## ישויות

 - ספר
 - מנוי
 - השאלת ספר
 ## מיפוי Routes לספר
 - שליפת רשימת הספרים- GET https://localhost:7137/api/Books
 - שליפת ספר לפי מזהה- GET https://localhost:7137/api/Books/1
 - הוספת ספר- POST https://localhost:7137/api/Books 
 - עדכון ספר- PUT   https://localhost:7137/api/Books/1
 - עדכון סטטוס- PUT   https://localhost:7137/api/Books/1/status
- מחיקת ספר- DELET  https://localhost:7137/api/Book/1
  ## מיפוי Routes למנוי
 - שליפת רשימת המנויים- GET https://localhost:7137/api/Members
 - שליפת מנוי לפי מזהה- GET https://localhost:7137/api/Members/1
 - הוספת מנוי- POST  https://localhost:7137/api/Members 
 - עדכון מנוי- PUT   https://localhost:7137/api/Members/1
 -  עדכון סטטוס- PUT   https://localhost:7137/api/Members/1/status
   - מחיקת מנוי- DELET  https://localhost:7137/api/Member/1
  ## מיפוי Routes להשאלה
 - שליפת רשימת ההשאלות- GET https://localhost:7137/api/Borrow
 - שליפת השאלה לפי מזהה- GET https://localhost:7137/api/Borrow/1
 - הוספת השאלה- POST  https://localhost:7137/api/Borrow 
 - עדכון השאלה- PUT   https://localhost:7137/api/Borrow/1
 
