/* Author:          ezhex1991@outlook.com
 * CreateTime:      2017-04-17 15:52:08
 * Organization:    #ORGANIZATION#
 * Description:     
 */
using UnityEngine;

namespace EZUnity
{
    public class EZMaterialSwitcher : EZSwitcher<Material>
    {
        [SerializeField]
        private Renderer m_Renderer;
        public Renderer renderer { get { return m_Renderer; } }

        [SerializeField]
        private bool m_SharedMaterial;
        public bool sharedMaterial { get { return m_SharedMaterial; } }

        public override void Switch(int index)
        {
            if (sharedMaterial)
                renderer.sharedMaterial = options[index];
            else
                renderer.material = options[index];
        }
    }
}
