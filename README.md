<div dir='rtl' lang='he'>

# מטלה 8 סעיף ה

לקחתי את הפרוייקט מהשיעור ועשיתי בו מספר שינויים:
1. הוספתי פונקציה שבודקת האם השחקן לחץ על איקס ואם כן, על איזה לחצן נוסף הוא לחץ (ימינה, שמאלה,למעלמה,למטה) כך שהפונקציה מחזירה את המיקום החדש-
https://github.com/Noa-Amit/Task8/blob/master/Assets/Scripts/2-player/KeyboardMover.cs
2. הוספתי פונקציה שמחכה שניה ואז משנה את האריח של ה mountains לאריח של grass.
3. הוספתי ל tilemap את הסקריפט החדש שכתבתי NewTilemapCaveGenerator

הסקריפטים שכתבתי:

1. NewMapTrigger- כשהשחקן נוגע בטריגר המשחק מתחיל מחדש, כלומר המפה משתנה והשחקן חוזר לנקודת ההתחלה
https://github.com/Noa-Amit/game-task8-tilemap-pathfinding/blob/main/Assets/Scripts/randomMap/newMapTrigger.cs

2. NewTilemapCaveGeneration- יוצר אוביקט מערה שמתאחלת מפה, ואת המפה מציג למסך. במפה יש 3 סוגי אריחים
https://github.com/Noa-Amit/game-task8-tilemap-pathfinding/blob/main/Assets/Scripts/randomMap/NewTilemapCaveGenerator.cs

3. NewCaveGenerator-אוביקט שיוצר מפה רנדומלית חדשה. הקוד כתוב באופן כללי כך שמי שקורא לאוביקט מחליט מה יהיה מספר האריחים על המפה
האוביקט מקבל מערך של מספרים שמייצגים את ההסתברות להופעת כל אריח על המפה ולפי הנתונים האלו מאתחל מפה
https://github.com/Noa-Amit/game-task8-tilemap-pathfinding/blob/main/Assets/Scripts/randomMap/NewCaveGenerator.cs
