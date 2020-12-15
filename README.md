<div dir='rtl' lang='he'>

# מטלה 8 סעיף ה

לקחתי את הפרוייקט מהשיעור ועשיתי בו מספר שינויים:
1. הוספתי פונקציה ל KeyboardMover שבודקת האם השחקן לחץ על X ואם כן, על איזה לחצן נוסף הוא לחץ (ימינה, שמאלה,למעלמה,למטה) כך שהפונקציה מחזירה את המיקום החדש-
https://github.com/Noa-Amit/Task8/blob/master/Assets/Scripts/2-player/KeyboardMover.cs
2. הוספתי פונקציה ל KeyboardMoverByTile שמחכה שניה ואז משנה את האריח של ה mountains לאריח של grass.
3. בתוך ה KeyboardMoverByTile הוספתי לפונקציית update תנאי חדש שבודק קודם כל אם השחקן לחץ על X ואז על לחצן נוסף (ימינה, שמאלה, למטה, למעלה) ובנוסף בודק האם במיקום החדש אליו השחקן רוצה ללכת יש הר. אם כן, הוא נשלח לפונקציה שהוספתי וכתבתי בסעיף הקודם (2).
https://github.com/Noa-Amit/Task8/blob/master/Assets/Scripts/2-player/KeyboardMoverByTile.cs
