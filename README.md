# משכנתא ראנר (Mashkanta Runner)

🎮 משחק 2D מסוג Runner המדמה מסלול משכנתא – איסוף בונוסים, התחמקות ממלכודות, שמירה על כסף, וחישוב פוטנציאל חיסכון ממיחזור משכנתא.

---

## 🗂 מבנה תיקיות

```
Assets/
├── Scenes/         ← סצנות המשחק (MainMenu, Gameplay, וכו')
├── Scripts/
│   ├── Core/       ← GameManager, SceneLoader, GameStats
│   ├── Player/     ← שליטה בשחקן
│   ├── Logic/      ← לוגיקת חישוב ירידת כסף
│   ├── Objects/    ← תגובות למלכודות ובונוסים
│   └── UI/         ← תצוגות HUD וסיכום
├── Prefabs/        ← דמות השחקן, בונוסים, מלכודות
├── Materials/, Audio/, Fonts/
```

---

## ▶️ איך להריץ

1. פתח את Unity → צור פרויקט חדש בתצורת 2D
2. גרור את כל התיקיות מהקובץ לתוך התיקייה `Assets/`
3. הוסף את הסצנות `Scenes/*` ל-Build Settings (File → Build Settings)
4. לחץ `Play` מסצנת Gameplay או MainMenu
5. ודא שאין שגיאות ב-Console

---

## ⚙️ רכיבים עיקריים

- **PlayerController.cs** – תנועת ריצה פשוטה
- **MoneyLogic.cs** – ירידת כסף לפי interestRate ו-riskMultiplier
- **Bonus.cs / Trap.cs** – השפעות של אובייקטים
- **GameStats.cs** – משתני משחק גלובליים
- **Prefabs** – כולל אובייקטי placeholder ל-Bonus, Trap ו-Player

---

## 🔄 המשך פיתוח (המלצות)

- טופס קלט לנתוני שחקן (ריבית, תקופה, סכום)
- חיבור Webhook ליועץ או API לשיתוף תוצאה
- אנימציות, UI מלא, סאונד
- תמיכה מלאה ב-RTL + תרגום

---

בהצלחה! 💰