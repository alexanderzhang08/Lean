/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using QuantConnect.Orders;

namespace QuantConnect.Securities.Positions
{
    /// <summary>
    /// Parameters for the <see cref="IPositionGroupBuyingPowerModel.GetInitialMarginRequiredForOrder"/>
    /// </summary>
    public class PositionGroupInitialMarginRequiredForOrderParameters
    {
        /// <summary>
        /// Gets the order whose initial margin requirement is to be computed
        /// </summary>
        public Order Order { get; }

        /// <summary>
        /// Gets the position group that represents the changes resulting from executing the <see cref="Order"/>
        /// </summary>
        public IPositionGroup PositionGroup { get; }

        /// <summary>
        /// Gets the algorithm's portfolio manager
        /// </summary>
        public SecurityPortfolioManager Portfolio { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionGroupInitialMarginRequiredForOrderParameters"/> class
        /// </summary>
        /// <param name="portfolio">The algorithm's portfolio manager</param>
        /// <param name="positionGroup">The position group</param>
        /// <param name="order">The order</param>
        public PositionGroupInitialMarginRequiredForOrderParameters(
            SecurityPortfolioManager portfolio,
            IPositionGroup positionGroup,
            Order order
            )
        {
            Order = order;
            Portfolio = portfolio;
            PositionGroup = positionGroup;
        }
    }
}
