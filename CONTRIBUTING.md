# 👥 מדריך לפיתוח ושיתוף פעולה – משכנתא ראנר

ברוכים הבאים לצוות הפיתוח של משחק **משכנתא ראנר**! 🚀  
במדריך זה תמצאו הנחיות לעבודה מסודרת עם הקוד, תרומות לפיצ'רים חדשים ותחזוקת הפרויקט.

---

## 📁 מבנה בסיסי

- **Scenes/** – כל סצנה ב-Unity כקובץ `.unity`
- **Scripts/** – סקריפטים ממוינים לפי תחום (Player, UI, Logic)
- **Prefabs/** – כל אובייקט שימושי מוגדר כ־Prefab
- **README.md** – הסבר כולל על מטרת המשחק ואופן ההרצה
- **CONTRIBUTING.md** – מסמך זה

---

## 🛠 פיתוח מקומי

1. פתח את Unity (גרסה מומלצת: `2021.3+`)
2. טען את תיקיית `MashkantaRunner` כתיקיית פרויקט
3. ודא שכל הסצנות תחת `Scenes/` רשומות ב־Build Settings
4. לחץ על Play להרצה

---

## ✅ כללי קידוד

- כתוב קוד ב־C# לפי עקרונות Clean Code ו־SOLID
- שמות משתנים ופונקציות תמיד באנגלית ברורה
- סדר את הסקריפטים בתיקיות בהתאם (Core, Logic, UI וכו׳)
- ציין `TODO:` או `FIXME:` בקוד זמני או לא שלם

---

## 🧪 בדיקות

לפני פוש ל־main:
- ודא שהמשחק רץ ללא שגיאות ב־Console
- בדוק סצנות חדשות (UI מחובר, טריגרים פועלים)
- הקפד לא לשבור Prefabs קיימים

---

## 🌐 פריסה ל־WebGL

1. פתח `File > Build Settings`
2. בחר פלטפורמה `WebGL` ולחץ `Switch Platform`
3. לחץ `Build` → בחר תיקייה `Builds/WebGL`
4. ניתן לפרוס את התוצר ל־GitHub Pages או itch.io

---

## 📤 שליחת שינויים

- עבודה מול Git: השתמש ב־branchים לפיצ׳רים (feature/add-x)
- בצע Commit עם הודעה ברורה
- שלח Pull Request עם תיאור קצר ושינויים עיקריים
- תעדכן את `README.md` או `CONTRIBUTING.md` אם דרוש

---

## 💡 הצעות לפיצ׳רים

- מסך תוצאות עם ניתוח גרפי
- מערכת יועץ מבוססת AI
- יותר סוגי מלכודות/בונוסים
- תרגום מלא ותמיכה ב־RTL

---

תודה שאתה תורם לפרויקט 🙌