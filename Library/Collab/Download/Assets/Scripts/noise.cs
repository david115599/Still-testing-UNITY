using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class noise {

    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];
        if (scale <= 0) {
            scale = 0.0000000000000000001f;
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapWidth; y++) {
                    float sampleX = x / scale;
                    float SampleY = y / scale;

                    float perlinValue = Mathf.PerlinNoise(sampleX, SampleY);
                    noiseMap[x, y] = perlinValue;
                }
            }
        }
        return noiseMap;
    }
}
