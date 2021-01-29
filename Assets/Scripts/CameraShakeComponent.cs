using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeComponent : MonoBehaviour
{

    /// <summary>
    /// (código de Brackeys <3)
    /// Agita la cámara según la magnitud, durante el tiempo especificado.
    /// La magnitud consiste en el desplazamiento máximo que puede efectuar.
    /// La magnitud aplicada es un valor aleatorio entre 1 y la magnitud. Positivo o negativo.
    /// </summary>
    /// <param name="duration">Duración del agitado</param>
    /// <param name="magnitude">Magnitud del agitado</param>
    /// <returns></returns>
    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}
