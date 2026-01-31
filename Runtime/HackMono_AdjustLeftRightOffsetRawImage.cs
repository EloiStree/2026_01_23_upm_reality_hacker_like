using UnityEngine;

public class HackMono_AdjustLeftRightOffsetRawImage : MonoBehaviour
{
    [SerializeField] private RectTransform m_leftRect;
    [SerializeField] private RectTransform m_rightRect;

    [Range(0f, 1f)]
    [SerializeField] private float m_percent = 0f;

    public void SetPivots(float value)
    {
        m_percent = Mathf.Clamp01(value);

        if (m_leftRect != null)
        {
            float leftPivotX = Mathf.Lerp(0.5f, 0f, m_percent);
            m_leftRect.pivot = new Vector2(leftPivotX, m_leftRect.pivot.y);
        }

        if (m_rightRect != null)
        {
            float rightPivotX = Mathf.Lerp(0.5f, 1f, m_percent);
            m_rightRect.pivot = new Vector2(rightPivotX, m_rightRect.pivot.y);
        }
    }

    private void OnValidate()
    {
        SetPivots(m_percent);
    }
}

