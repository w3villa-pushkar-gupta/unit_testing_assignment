## ⚠️ Edge Cases Covered

| Test                                      | Edge Case                                | Expected Behavior               |
|-------------------------------------------|------------------------------------------|---------------------------------|
| `Add_Overflow_ThrowsOverflowException`     | Adding numbers beyond `int.MaxValue`     | Throws exception                |
| `Subtract_Underflow_ThrowsOverflowException` | Subtracting below `int.MinValue`         | Throws exception                |

---

## ❗ Risks if Unit Tests Are Skipped

If you skip unit tests:

- **Hidden Bugs** — Arithmetic overflow or underflow could crash your app in production.  
- **Regression Failures** — Future changes might break existing logic unnoticed.  
- **Unreliable Code** — Without tests, developers can’t confidently refactor or optimize.  
- **Increased Costs** — Bugs caught late (in QA or production) are much more expensive to fix.  
- **Loss of Trust** — Your system may behave unpredictably under real-world inputs.  
