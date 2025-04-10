# Ease Function Kit

This implementation provides a simple set of easing functions for various speed modifications in Unity. Easing functions are commonly used in animations to create smooth transitions and control the rate of change over time, allowing for effects like acceleration, deceleration, and oscillation. These native C# implementations are adapted from examples available on [Easings.net](https://easings.net/), a popular resource for visualizing and understanding easing curves. The functions are designed to work seamlessly with Unity’s animation and movement systems, giving developers the ability to easily apply different types of motion, such as linear, quadratic, cubic, and elastic, to their game objects or UI elements. These easing functions are ideal for fine-tuning animations, transitions, and movement behaviors in games or interactive applications.

### Easing Functions

- [InExpo](https://easings.net/#easeInExpo)
- [OutExpo](https://easings.net/#easeOutExpo)
- [InOutExpo](https://easings.net/#easeInOutExpo)
- [InBack](https://easings.net/#easeInBack)
- [OutBack](https://easings.net/#easeOutBack)
- [InOutBack](https://easings.net/#easeInOutBack)
- [InSine](https://easings.net/#easeInSine)
- [OutSine](https://easings.net/#easeOutSine)
- [InOutSine](https://easings.net/#easeInOutSine)
- [InCubic](https://easings.net/#easeInCubic)
- [OutCubic](https://easings.net/#easeOutCubic)
- [InOutCubic](https://easings.net/#easeInOutCubic)
- [InQuint](https://easings.net/#easeInQuint)
- [OutQuint](https://easings.net/#easeOutQuint)
- [InOutQuint](https://easings.net/#easeInOutQuint)
- [InCirc](https://easings.net/#easeInCirc)
- [OutCirc](https://easings.net/#easeOutCirc)
- [InOutCirc](https://easings.net/#easeInOutCirc)
- [InElastic](https://easings.net/#easeInElastic)
- [OutElastic](https://easings.net/#easeOutElastic)
- [InOutElastic](https://easings.net/#easeInOutElastic)
- [InQuad](https://easings.net/#easeInQuad)
- [OutQuad](https://easings.net/#easeOutQuad)
- [InOutQuad](https://easings.net/#easeInOutQuad)
- [InQuart](https://easings.net/#easeInQuart)
- [OutQuart](https://easings.net/#easeOutQuart)
- [InOutQuart](https://easings.net/#easeInOutQuart)

### Example of Usage
Instead of the direct value of `t / time`, we may use the output of the `Calc` function to simulate a more organic acceleration. In the example we used the `OutBack` acceleration function.
```cs
[SerializeField] private EaseCurve curve = new EaseCurve(Ease.OutBack);

private IEnumerator ScaleTween(Vector2 from, Vector2 to, float time)
{
    float t = 0.0f;

    while (t < time)
    {
        t += Time.deltaTime;
        transform.localScale = Vector2.LerpUnclamped(from, to, curve.Calc(t / time));
        yield return null;
    }

    transform.localScale = to;
}
```
<b>NOTE:</b> Some curves like `OutBack` may overshoot the the range of `[0.0, 1.0]`. In these cases you should use `LerpUnclamped` instead of `Lerp`.
