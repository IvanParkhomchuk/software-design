using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2
{
    internal class ArtefactContainer : Artefact
    {
        private List<Artefact> _nestedArtefacts = new List<Artefact>();

        public ArtefactContainer(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {

        }

        public override int GetPowerBuf()
        {
            return this._nestedArtefacts.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
        }

        public override int GetWeight()
        {
            return this._nestedArtefacts.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
        }

        public void AddArtefact(Artefact artefact)
        {
            this._nestedArtefacts.Add(artefact);
        }

        public void RemoveArtefact(Artefact artefact)
        {
            this._nestedArtefacts.Remove(artefact);
        }

        public override int GetCount()
        {
            return this._nestedArtefacts.Aggregate(1, (sum, next) => sum += next.GetCount());
        }
    }
}
